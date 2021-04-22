using Mirror;
using UnityEngine;
using UnityEngine.InputSystem;


public enum ActionMode {
    Default=0,
    Pilot,
    Gunner
}

[RequireComponent(typeof(PlayerInput))]
public class PlayerScript : NetworkBehaviour
{
    public TextMesh playerNameText;
    public GameObject floatingInfo;
    public SceneScript sceneScript;
    public float playerSpeed = 4f;

    private float cameraAngleX;
    [SerializeField] private ConsoleScript targetedConsole;
    [SerializeField] private ShipScript currentShip;
    private PlayerInput playerInput;

    private Vector2 movementInput = new Vector2();

    private CharacterController controller;

    Vector3 angles, velocity;
    bool jump = false;

    private bool allowCursor = false;

    [SyncVar(hook = nameof(OnNameChanged))]
    public string playerName;

    [SyncVar(hook = nameof(OnColorChanged))]
    public Color playerColor = Color.white;

    [SyncVar(hook = nameof(OnActionModeChanged))]
    public ActionMode actionModeSynced = ActionMode.Default;

    private bool LookEnabled = true;

    void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;
        var sceneReference = GameObject.Find("SceneReference").GetComponent<SceneReference>();
        sceneScript = sceneReference.sceneScript;
        currentShip = sceneReference.shipScript;
        targetedConsole = sceneReference.shipConsole;
        controller = GetComponent<CharacterController>();
    }

    void OnNameChanged(string _Old, string _New)
    {
        playerNameText.text = playerName;
    }

    void OnColorChanged(Color _Old, Color _New)
    {
        playerNameText.color = _New;
    }

    void OnActionModeChanged(ActionMode _Old, ActionMode _New) {
        if (_New == ActionMode.Default) {
            Camera.main.enabled = true;
            playerInput.SwitchCurrentActionMap("Player");
        }
        else if (_New  == ActionMode.Pilot) {
            Camera.main.enabled = false;
            playerInput.SwitchCurrentActionMap("ShipFlight");
        }
    }

    // Start is called before the first frame update
    public override void OnStartLocalPlayer()
    {
        // sceneScript.playerScript = this;
        // transform.SetParent(currentShip.gameObject.transform);
        Camera.main.transform.SetParent(transform);
        Camera.main.transform.localPosition = new Vector3(0,.5f,0);

        string name = "Player" + Random.Range(100, 999);
        Color color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        CmdSetupPlayer(name, color);
    }

    public override void OnStartAuthority()
    {
        base.OnStartAuthority();
 
        UnityEngine.InputSystem.PlayerInput playerInput = GetComponent<UnityEngine.InputSystem.PlayerInput>();
        playerInput.enabled = true;
    }
    
    [Command]
    public void CmdSendPlayerMessage()
    {
        if (sceneScript) 
        { 
            sceneScript.statusText = $"{playerName} says hello {Random.Range(10, 99)}";
        }
    }

    [Command]
    public void CmdSetupPlayer(string _name, Color _col)
    {
        // player info sent to server, then server updates sync vars which handles it on all clients
        playerName = _name;
        playerColor = _col;
        sceneScript.statusText = $"{playerName} joined.";
    }

    [Command]
    public void SetActionMode(ActionMode mode) {
        actionModeSynced = mode;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerInput == null) {
            playerInput = GetComponent<PlayerInput>();
        }
        if (!isLocalPlayer) { 
            floatingInfo.transform.LookAt(Camera.main.transform);
            return; 
        }
    }

    void FixedUpdate() {
        var grounded = controller.isGrounded;
        // Player movement
        var movement = Vector3.zero;
        movement =  movementInput.x * transform.right;
        movement += movementInput.y * transform.forward;
        controller.Move(movement * playerSpeed * Time.fixedDeltaTime);
        // Gravity
        if (grounded && Vector3.Dot(velocity, transform.up) < 0) {
            velocity = Vector3.zero;
        }
        velocity += -9.81f * Time.fixedDeltaTime * transform.up;
        if (grounded && jump) {
            velocity += Mathf.Sqrt(3f * 9.81f) * transform.up;
        }
        controller.Move(velocity * Time.fixedDeltaTime);
        Debug.Log(grounded);
        jump = false;

        transform.rotation = Quaternion.Euler(angles);
        var cameraRotation = Quaternion.Euler(new Vector3(cameraAngleX, 0f, 0f));
        Camera.main.transform.localRotation = cameraRotation;
    }

    void ToggleCursor() {
        allowCursor = !allowCursor;
        Cursor.lockState = allowCursor ? CursorLockMode.Confined : CursorLockMode.Locked;
        Debug.Log("Cursor State :" + (allowCursor ? "CursorLockMode.Confined" : "CursorLockMode.Locked"));
    }

    void OnLook(InputValue value)
    {
        if (!LookEnabled) {
            return;
        }
        var mouseDeltas = value.Get<Vector2>() * Time.fixedDeltaTime;
        angles.y += mouseDeltas.x; 
        cameraAngleX = Mathf.Clamp(cameraAngleX - mouseDeltas.y, -90f, 90f);
    }
    void OnMove(InputValue value)
    {
        movementInput = value.Get<Vector2>();
    }

    void OnJump(InputValue value) 
    {
        jump = Mathf.RoundToInt(value.Get<float>()) == 1;
    }

    void OnFire(InputValue value)
    {
        
    }

    void OnSwitchTool(InputValue value)
    {
    
    }

    void OnChat(InputValue value)
    {
        ToggleCursor();
    }

    void OnMenu(InputValue value)
    {
        ToggleCursor();
        LookEnabled = !LookEnabled;
    }

    void OnInteract(InputValue value) {
        var console = GameObject.Find("Console").GetComponent<ConsoleScript>();
        if (!console)
            return;
        playerInput.enabled = !playerInput.enabled;
        console.Activate(gameObject);
        console.Deactivate();
    }
}
