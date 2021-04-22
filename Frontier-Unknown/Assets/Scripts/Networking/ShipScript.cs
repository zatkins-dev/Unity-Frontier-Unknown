using System.Collections.Generic;
using Mirror;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

[RequireComponent(typeof(NetworkTransform))]
[RequireComponent(typeof(PlayerInput))]
[RequireComponent(typeof(Rigidbody))]
public class ShipScript : NetworkBehaviour
{
    [Header("Ship Base Parameters")] [Tooltip("Ship Health (turret bullet does 2)")] [Range(50f, 500f)]
    public float maxHealth = 500f;

    [Header("Ship Acceleration Parameters")] [Tooltip("Maximum ship speed (m/s)")] [Range(20f, 200f)]
    public float maxSpeed = 100f;

    [Space(12)] [Tooltip("Force of the thruster (kN)")] [Range(1f, 50f)]
    public float forceThrust = 8f;

    [Tooltip("Force of the horizontal strafing thrusters (kN)")] [Range(0f, 15f)]
    public float forceHorizontalStrafe = 1f;

    [Tooltip("Force of the vertical strafing thrusters (kN)")] [Range(0f, 15f)]
    public float forceVerticalStrafe = 1f;

    [Tooltip("Force of the braking thrusters (kN)")] [Range(1f, 50f)]
    public float forceBrake = 8f;

    [Tooltip("Speed of the roll thrusters (m/s)")] [Range(1f, 20f)]
    public float DVRoll = 7.5f;

    [Tooltip("Speed of the steering thrusters (m/s)")] [Range(5f, 60f)]
    public float DVSteer = 20f;

    [Header("References")] public Transform floatingInfo;

    public TMP_Text FloatingNameText;
    public TMP_Text FloatingHealthText;
    public Camera pilotCamera;
    public List<TurretScript> turrets;
    public GameObject root;

    [SerializeField] private HUDMap _minimapRef;
    private Dictionary<MeshRenderer, Color> origColors;

    [SyncVar] public int TeamID;
    [SyncVar] public string PlayerName;

    [SyncVar(hook = nameof(OnHealthChanged))]
    float _health;

    [SyncVar(hook = nameof(OnScoreChanged))]
    int _score;

    [SyncVar(hook = nameof(ObjectSpawned))] private GameObject lastSpawnedGameObject;
    int _shipId;

    private PlayerInput _playerInput;
    SceneScript _sceneScript;
    Rigidbody _shipRigidbody;
    Transform _root;
    Vector2 _accelInput;
    Vector3 _angles, _velocity;
    float _roll, _hover, _brake;

    private bool _lookEnabled = true;
    private bool _allowCursor;

    // Start is called before the first frame update
    void Start()
    {
        _shipRigidbody = GetComponent<Rigidbody>();
        _root = _shipRigidbody.transform;
        _angles = _root.eulerAngles;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Awake()
    {
        _shipRigidbody = GetComponent<Rigidbody>();
        _root = _shipRigidbody.transform;
        _angles = _root.transform.eulerAngles;
        Cursor.lockState = CursorLockMode.Confined;
        _shipRigidbody.velocity = Vector3.zero;
        var sceneReference = GameObject.Find("SceneReference").GetComponent<SceneReference>();
        _sceneScript = sceneReference.sceneScript;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isLocalPlayer)
        {
            floatingInfo.LookAt(Camera.main.transform);
            return;
        }

        _shipRigidbody.transform.rotation *= Quaternion.Euler(new Vector3(0, 0, _roll * DVRoll * Time.fixedDeltaTime)); //* Quaternion.Euler(new Vector3(_angles.x, _angles.y,0));
        for (int i = 0; i < turrets.Count; i++)
        {
            _sceneScript.hud.UpdateAmmoText(i, turrets[i].Ammo(), turrets[i].m_magazineSize);
        }
    }

    void FixedUpdate()
    {
        var forwardForce = 1000f * _accelInput.y * forceThrust * _root.forward;
        var horizontalForce = 1000f * _accelInput.x * forceHorizontalStrafe * _root.right;
        var verticalForce = 1000f * _hover * forceVerticalStrafe * _root.up;
        var netForce = forwardForce + horizontalForce + verticalForce;
        var deltaVInput = (netForce / _shipRigidbody.mass) * Time.fixedDeltaTime;
        var newVel = Vector3.ClampMagnitude(_shipRigidbody.velocity + deltaVInput, maxSpeed);
        var deltaV = (newVel - _shipRigidbody.velocity);
        _shipRigidbody.AddForce(deltaV, ForceMode.VelocityChange);
        var vel = _shipRigidbody.velocity;
        var brakeVel = _brake *
                       (-1f * Mathf.Min(1000f * forceBrake / _shipRigidbody.mass, vel.magnitude) * vel.normalized);
        _shipRigidbody.AddForce(brakeVel * Time.fixedDeltaTime, ForceMode.VelocityChange);
        if (_brake > 0)
        {
            var angVel = _shipRigidbody.angularVelocity;
            _shipRigidbody.angularVelocity -= Mathf.Min(1000f * forceBrake / _shipRigidbody.mass, angVel.magnitude) * angVel.normalized;
        }
        if (_shipRigidbody.position.magnitude > 2000) _shipRigidbody.position = -_shipRigidbody.position;
        
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log($"Collided with {collision.collider.name} [{collision.collider.tag}]");
        if (!isLocalPlayer)
        {
            return;
        }

        //Output the Collider's GameObject's name
        if (_health <= 0) return;
        var projTeam = collision.gameObject.GetComponent<ProjectileTeam>();
        if (projTeam != null)
        {
            Debug.Log($"Hit by {(projTeam.Type == 0 ? "Missile" : "Turret")} projectile from team {projTeam.TeamID}");
            if (projTeam.TeamID == TeamID)
            {
                Debug.Log(
                    $"TeamID of projectile {collision.collider.name} == this.TeamID ({TeamID}), ignoring collision");
                return;
            }

            switch (projTeam.Type)
            {
                case ProjectileType.Turret:
                    Destroy(collision.collider.gameObject);
                    CmdTakeDamage(40);
            break;
                case ProjectileType.Missile:
                    Destroy(collision.collider.gameObject);
                    CmdTakeDamage(25);
            break;
                default:
                    Debug.Log($"Unknown projectile {collision.collider.name}");
                    Destroy(collision.collider.gameObject);
                    return;
            }

        }
        else if (collision.collider.GetComponentInParent<Rigidbody>() != null && collision.collider.GetComponentInParent<Rigidbody>().gameObject.CompareTag("Ship"))
        {
            CmdTakeDamage(150);
        }
    }

    public override void OnStartClient()
    {
        Debug.Log($"in onstartclient: playername = {PlayerName}");
        FloatingNameText.text = PlayerName;
        foreach (var meshRenderer in root.GetComponentsInChildren<MeshRenderer>())
        {
            meshRenderer.material.color = 0.5f * (meshRenderer.material.color + _minimapRef.TeamColors[TeamID]);
            FloatingNameText.color = 0.4f * Color.white + 0.6f * _minimapRef.TeamColors[TeamID];
        }
        int layer = LayerMask.NameToLayer($"Team{TeamID}");
        gameObject.layer = layer;
        foreach (var obj in gameObject.GetComponentsInChildren<Component>())
        {
            obj.gameObject.layer = layer;
        }
    }

    public override void OnStartLocalPlayer()
    {
        pilotCamera = Camera.main;
        Camera.main.transform.SetParent(transform);
        Camera.main.transform.rotation = Quaternion.identity;
        Camera.main.transform.localPosition = new Vector3(0, 2f, 11.7f);
        foreach (var t in turrets)
        {
            t.SetShip(this);
        }

        _sceneScript.hud.SetAmmoEnabled(0b11);

        _sceneScript.hud.playerTransform = transform;
        CmdSetupPlayer();
    }

    public override void OnStartAuthority()
    {
        base.OnStartAuthority();

        _playerInput = GetComponent<PlayerInput>();
        _playerInput.enabled = true;
    }

    [Command(requiresAuthority = false)]
    public void CmdCreateTurretBullet(GameObject prefab, Vector3 position, Quaternion rotation, float force)
    {
        var bullet = Instantiate(NetworkManager.singleton.spawnPrefabs[1], position, rotation);
        bullet.name = $"TurretProjectile-{TeamID}";
        bullet.GetComponent<ProjectileTeam>().TeamID = TeamID;
        bullet.GetComponent<Rigidbody>().velocity = Vector3.zero;
        bullet.GetComponent<Rigidbody>().AddForce(bullet.transform.forward * force, ForceMode.Impulse);
        Destroy(bullet, 20);
        NetworkServer.Spawn(bullet, gameObject);
        lastSpawnedGameObject = bullet;
    }

    [Command(requiresAuthority = false)]
    public void CmdCreateMissileBullet(GameObject prefab, Vector3 position, Quaternion rotation, Transform target)
    {
        var missileGameObject = Instantiate(NetworkManager.singleton.spawnPrefabs[0], position, rotation);
        missileGameObject.name = $"Missile-{TeamID}";
        missileGameObject.GetComponent<ProjectileTeam>().TeamID = TeamID;
        var missile = missileGameObject.GetComponent<Missile>();
        missile.missileTarget = target;
        Destroy(missileGameObject, 20);
        NetworkServer.Spawn(missileGameObject);
        lastSpawnedGameObject = missileGameObject;
    }

    [Command]
    void CmdTakeDamage(int damage)
    {
        _health -= damage;
    }

    [Command]
    void CmdDestroy()
    {
        var manager = NetworkManager.singleton as RoomManager;
        manager.Teams[TeamID].Tickets -= Mathf.RoundToInt(maxHealth);
        _score = manager.Teams[TeamID].Tickets;
        _health = maxHealth;
        // play explosion animation
    }

    [Command]
    void CmdSetupPlayer()
    {
        var manager = NetworkManager.singleton as RoomManager;
        _score = manager.Teams[TeamID].Tickets;
        _health = maxHealth;
    }

    // SyncVar hooks
    void ObjectSpawned(GameObject _, GameObject @new)
    {
        Destroy(@new, 20);
    }

    void OnHealthChanged(float old, float @new) 
    {
        Debug.Log("Health changed: " + old + " -> " + @new);
        FloatingHealthText.text = $"{Mathf.RoundToInt(@new)}/{Mathf.RoundToInt(maxHealth)}";
        if (isLocalPlayer) 
            _sceneScript.hud.UpdateHealth(@new, maxHealth);
        if (@new <= 0) {
            var respawnPosition = NetworkManager.singleton.GetStartPosition();
            _shipRigidbody.ResetInertiaTensor();
            _root.position = respawnPosition.position;
            _root.rotation = Quaternion.identity;
            foreach (var turret in turrets)
            {
                turret.Reset();
            }

            CmdDestroy();
        }
    }

    void OnScoreChanged(int old, int @new) 
    {
        if (!isLocalPlayer) { return; }
        Debug.Log("Score changed: " + old + " -> " + @new);
        _sceneScript.hud.UpdateScore(@new); 
    }

    // Input
    void ToggleCursor()
    {
        _allowCursor = !_allowCursor;
        Cursor.lockState = _allowCursor ? CursorLockMode.Confined : CursorLockMode.Locked;
        Cursor.visible = Cursor.lockState == CursorLockMode.Confined;
        Debug.Log("Cursor State :" + (_allowCursor ? "CursorLockMode.Confined" : "CursorLockMode.Locked"));
    }

    public void OnLook(InputValue value)
    {
        if (!isLocalPlayer) { return; }
        if (!_lookEnabled)
        {
            return;
        }
        var mouseDeltas = value.Get<Vector2>() * DVSteer * Time.fixedDeltaTime;
        _root.rotation *= Quaternion.Euler(-mouseDeltas.y, mouseDeltas.x, 0);
        //_angles = _root.eulerAngles;
        //_angles.x -= mouseDeltas.y;
        //_angles.y += mouseDeltas.x; 
    }

    public void OnAccelerate(InputValue value)
    {
        if (!isLocalPlayer) { return; }
        _accelInput = value.Get<Vector2>();
    }

    public void OnRoll(InputValue value)
    {
        if (!isLocalPlayer) { return; }
        _roll = value.Get<float>();
    }

    public void OnHover(InputValue value)
    {
        if (!isLocalPlayer) { return; }
        _hover = value.Get<float>();
    }

    public void OnBrake(InputValue value)
    {
        if (!isLocalPlayer) { return; }
        _brake = value.Get<float>();
    }

    public void OnFireL(InputValue value)
    {
        turrets[0].Fire();
    }
    public void OnFireR(InputValue value)
    {
        turrets[1].Fire();
    }

    public void OnReload(InputValue value)
    {
        if (!isLocalPlayer) { return; }

        foreach (var t in turrets)
        {
            t.Reload();
        }
    }
    public void OnMenu(InputValue value)
    {
        ToggleCursor();
        _lookEnabled = !_lookEnabled;
    }
}
