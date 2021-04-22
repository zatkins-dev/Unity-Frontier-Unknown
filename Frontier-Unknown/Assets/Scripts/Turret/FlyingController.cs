using UnityEngine;
using UnityEngine.InputSystem;

public class FlyingController : MonoBehaviour
{
    public Rigidbody shipRigidbody;

    [Header("Ship Acceleration Parameters")]
    [Tooltip("Maximum ship speed (m/s)")]
    [Range(20f, 200f)]
    public float maxSpeed = 100f;
    [Space(12)]
    [Tooltip("Force of the thruster (kN)")]
    [Range(1f, 20f)]
    public float forceThrust = 8f;
    [Tooltip("Force of the horizontal strafing thrusters (kN)")]
    [Range(0f, 10f)]
    public float forceHorizontalStrafe = 1f;
    [Tooltip("Force of the vertical strafing thrusters (kN)")]
    [Range(0f, 10f)]
    public float forceVerticalStrafe = 1f;
    [Tooltip("Force of the braking thrusters (kN)")]
    [Range(1f, 20f)]
    public float forceBrake = 8f;
    [Tooltip("Speed of the roll thrusters (m/s)")]
    [Range(1f, 15f)]
    public float DVRoll = 7.5f;
    [Tooltip("Speed of the steering thrusters (m/s)")]
    [Range(5f, 60f)]
    public float DVSteer = 20f;



    Transform root;
    Vector2 accelInput;
    Vector3 angularVelocity, velocity;
    float roll, hover, brake;
    // Start is called before the first frame update
    void Start()
    {
        if (root == null)
            root = shipRigidbody.transform;
        angularVelocity = root.eulerAngles;
        Cursor.lockState = CursorLockMode.Confined;
    }

    // Update is called once per frame
    void Update()
    {
        angularVelocity.z += roll * DVRoll * Time.deltaTime; 
        shipRigidbody.rotation = Quaternion.Euler(angularVelocity);
    }

    void FixedUpdate()
    {

        if (shipRigidbody.velocity.magnitude < maxSpeed) {
            shipRigidbody.AddForce(1000f * accelInput.y * forceThrust * Time.fixedDeltaTime * root.forward, ForceMode.Impulse);
            shipRigidbody.AddForce(1000f * accelInput.x * forceHorizontalStrafe * Time.fixedDeltaTime * root.right, ForceMode.Impulse);
            shipRigidbody.AddForce(1000f * hover * forceVerticalStrafe * Time.fixedDeltaTime * root.up, ForceMode.Impulse);
        }
        var vel = shipRigidbody.velocity;
        if (brake > 0.1)
        {
            var brakeForce = -1000f * Mathf.Min(forceBrake, vel.magnitude * shipRigidbody.mass) * vel.normalized;
            shipRigidbody.AddForce(brakeForce * Time.fixedDeltaTime, ForceMode.Impulse);
        }
        Debug.Log(brake);
    }

    void OnLook(InputValue value)
    {
        var mouseDeltas = value.Get<Vector2>() * DVSteer * Time.deltaTime;
        angularVelocity.x -= mouseDeltas.y;
        angularVelocity.y += mouseDeltas.x; 
    }

    void OnAccelerate(InputValue value)
    {
        accelInput = value.Get<Vector2>();
    }

    void OnRoll(InputValue value)
    {
        roll = value.Get<float>();
    }

    void OnHover(InputValue value)
    {
        hover = value.Get<float>();
    }

    void OnBrake(InputValue value)
    {
        brake = value.Get<float>();
    }
}
