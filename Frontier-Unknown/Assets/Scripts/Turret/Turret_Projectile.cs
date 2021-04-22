using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;


public class Turret_Projectile : MonoBehaviour
{
    [Header("Prefabs")]
    //bullet
    public GameObject m_bullet;

    [Header("Reference")]
    //Reference
    public Transform m_attackPoint;

    [Header("Turrent Stats")]
    //bullet force
    public float m_force;

    //gun stats
    public float m_interBurstDelay, m_shotDelayInBurst, m_spreadRadius, m_reloadTime;
    public int m_magazineSize, m_bulletsPerTap;
    public bool m_isAutomatic;

    int m_bulletsLeft, m_bulletsShot;

    //bools
    bool m_shooting, m_ready, m_reloading, allowInvoke;


    [Header("Graphics & Sound")]
    //Graphics
    public GameObject m_muzzleFlash;
    public TextMeshProUGUI m_ammunitionGUI;

    //sfx
    AudioSource m_soundEffects;
    public float xSensitivity = 1.0f;
    public  float ySensitivity = 1.0f;

    private Controls controls;
    private Vector2 look_input;
    private float xRotation;

    private Transform turretTransform;
    Rigidbody TurretRigidBody;
    Vector3 angles;
    private float cameraAngleX;
    public Camera pilotCamera;

    private void Awake()
    {
        controls = new Controls();
        Cursor.lockState = CursorLockMode.Confined;
        TurretRigidBody = GetComponent<Rigidbody>();
        turretTransform = TurretRigidBody.transform;
        Cursor.lockState = CursorLockMode.Confined;
        angles = turretTransform.eulerAngles;

        //fill magazine
        m_bulletsLeft = m_magazineSize;
        m_ready = true;
        m_soundEffects = GetComponent<AudioSource>();
    }

    private void Update()
    {
        //MyInput();
        if (m_ammunitionGUI != null)
            m_ammunitionGUI.SetText(m_bulletsLeft / m_bulletsPerTap + " / " + m_magazineSize / m_bulletsPerTap);

        //look_input = controls.Turret.Look.ReadValue<Vector2>();
        //var mouseX = look_input.x * mouseSensitivity * Time.deltaTime;
        //var mouseY = look_input.y * mouseSensitivity * Time.deltaTime;
        //xRotation -= mouseY;
        //xRotation = Mathf.Clamp(xRotation, -80f, 80f);
        //transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
        //turretTransform.Rotate(Vector3.up * mouseX);
        TurretRigidBody.transform.rotation = Quaternion.Euler(angles);

        var cameraRotation = Quaternion.Euler(new Vector3(cameraAngleX, 0f, 0f));
        Camera.main.transform.localRotation = cameraRotation;

        //shooting
        if (m_ready && m_shooting && !m_reloading && m_bulletsLeft > 0)
        {

            m_soundEffects.Play();
            m_bulletsShot = 0;

            Shoot();
        }
    }

    private void OnEnable()
    {
        controls.Enable();
        pilotCamera = Camera.main;
        Camera.main.transform.SetParent(transform);
        Camera.main.transform.rotation = Quaternion.identity;
    }

    private void OnDisable()
    {
        controls.Disable();
    }


    private void Shoot()
    {
        m_ready = false;

        //spread
        float x = Random.Range(-m_spreadRadius, m_spreadRadius);
        float y = Random.Range(-m_spreadRadius, m_spreadRadius);

        //new direction with spread
        Vector3 directionWithSpread = m_attackPoint.forward + new Vector3(x, y, 0);

        //instantiate bullet
        GameObject currentBullet = ObjectPooler.SharedInstance.GetPooledObject(m_bullet.tag);
        if (currentBullet != null)
        {
            currentBullet.transform.position = m_attackPoint.position;
            currentBullet.transform.eulerAngles = m_attackPoint.eulerAngles;
            currentBullet.SetActive(true);

            //add forces to bullet
            var bulletRigidBody = currentBullet.GetComponent<Rigidbody>();
            bulletRigidBody.velocity = Vector3.zero;
            bulletRigidBody.AddForce(currentBullet.transform.forward * m_force, ForceMode.Impulse);
        }

        if (m_muzzleFlash != null)
        Instantiate(m_muzzleFlash, m_attackPoint.position, Quaternion.identity);

        m_bulletsLeft--;
        m_bulletsShot++;

        Invoke(nameof(ResetShot), m_interBurstDelay);
        if (allowInvoke)
        {
            allowInvoke = false;
        }

        if (m_bulletsShot < m_bulletsPerTap && m_bulletsLeft > 0)
            Invoke(nameof(Shoot), m_shotDelayInBurst);
    }

    private void ResetShot()
{
    //allow shooting and invoking
    m_ready = true;
    allowInvoke = true;
}

    private void Reload()
    {
        m_reloading = true;
        Invoke(nameof(ReloadFinished), m_reloadTime);
    }

    private void ReloadFinished()
    {
        m_bulletsLeft = m_magazineSize;
        m_reloading = false;
    }

    public void Fire()
    {
        Debug.Log("Fire called in turret");
        if (m_ready && !m_reloading && m_bulletsLeft <= 0)
            Reload();

        //shooting
        if (m_ready && !m_reloading && m_bulletsLeft > 0)
        {
            m_soundEffects.Play();
            m_bulletsShot = 0;
            Shoot();
        }
    }

    public void OnLook(InputValue value)
    {
        var mouseDeltas = value.Get<Vector2>() * Time.fixedDeltaTime;
        angles.x -= (mouseDeltas.y * ySensitivity);
        angles.y += (mouseDeltas.x * xSensitivity); 
    }

    public void OnFire(InputValue value)
    {
        Fire();
    }

    //public Vector3 GetBulletDirection()
    //{
    //    float x = Random.Range(-m_spreadRadius, m_spreadRadius);
    //    float y = Random.Range(-m_spreadRadius, m_spreadRadius);

    //    //new direction with spread
    //    return (m_attackPoint.forward + new Vector3(x, y, 0)).normalized;
    //}
}
