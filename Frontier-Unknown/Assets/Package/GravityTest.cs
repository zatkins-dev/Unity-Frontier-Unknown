using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GravityTest : MonoBehaviour
{
    public int gravityMode = 0;
    public int test = 0;
    public GameObject gravityCenter;
    public Collider gravityCenterCollider;
    public Vector3 gravityDirection;
    public Rigidbody rb;
    public Transform body;
    public int gravityFactor;
    bool grounded;
    public Vector3 gravityValue;
    //PlayerControls control;
    public Vector3 realativeDown;
    public Camera cam;
    [SerializeField]
    Vector2 look;
    [SerializeField]
    Vector2 move;
    [SerializeField]
    float velocity;
    [SerializeField]
    float turnSensitivity;
    [SerializeField]
    float speedLimit;
    float lookPitch;
    Vector3 moveForce;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent(typeof(Rigidbody)) as Rigidbody;
    }

    // Update is called once per frame
    void Update()
    {
        Vision();
        Debug.DrawRay(transform.position, moveForce, Color.cyan, 30);
    }

    private void FixedUpdate()
    {
        Movement();
        switch (gravityMode)
        {
            case 0:
                PointGravity();
                break;
            case 1:
                DirectionGravity();
                break;
            case 2:
                SurfaceGravity();
                break;
            default:
                PointGravity();
                break;
        }
            

        
    }

    void PointGravity()
    {
        gravityDirection = gravityCenter.transform.position - transform.position;
        transform.rotation = Quaternion.LookRotation((gravityDirection), transform.up);
    }

    void DirectionGravity()
    {
        gravityDirection = realativeDown;
        transform.rotation = Quaternion.LookRotation((gravityDirection), transform.up);
    }
    
    void SurfaceGravity()
    {
        gravityDirection = gravityCenterCollider.ClosestPoint(transform.position) - transform.position;
        transform.rotation = Quaternion.LookRotation((gravityDirection), transform.up);
    }

    private void Movement()
    {
        float forwardBack = move.y;
        float leftRight = move.x;
        moveForce = Vector3.ClampMagnitude(body.transform.rotation * new Vector3(leftRight * velocity, rb.velocity.y, forwardBack * velocity), speedLimit);
        gravityValue = (gravityFactor * rb.mass * 9.81f * .02f * (gravityDirection).normalized) + gravityValue;
        rb.velocity = moveForce + gravityValue;
        //rb.AddForce(gravityFactor* rb.mass * 9.81f * (gravityCenter.transform.position - transform.position).normalized);
    }

    private void Vision()
    {
        body.transform.Rotate(0, look.x * turnSensitivity, 0);

        if (cam != null)
        {
            lookPitch -= look.y * turnSensitivity;
            lookPitch = Mathf.Clamp(lookPitch, -90, 90);
            cam.transform.localEulerAngles = new Vector3(lookPitch, 0, 0);
        }

        //    Vector3.left, look.y * turnSensitivity;

        //transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y + 1, transform.rotation.z);
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.transform.tag == "Ground")
        {
            gravityValue = Vector3.zero;
            grounded = true;
        }
    }

    public void SetDirection(float x, float y, float z)
    {
        realativeDown = new Vector3(x,y,z);
    }
}
