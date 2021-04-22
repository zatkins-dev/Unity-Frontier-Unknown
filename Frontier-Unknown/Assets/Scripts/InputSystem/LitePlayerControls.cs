using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]
[RequireComponent(typeof(PlayerInput))]
public class LitePlayerControls : MonoBehaviour
{
    public float playerSpeed = 4f;
    private CharacterController controller;
    private float cameraAngleX;
    bool jump = false;
    private Vector2 movementInput = new Vector2();
    private Vector3 velocity = new Vector3();

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        var grounded = controller.isGrounded;

        // Player movement
        var movement = Vector3.zero;
        movement =  movementInput.x * transform.right;
        movement += movementInput.y * transform.forward;
        controller.Move(movement * playerSpeed * Time.deltaTime);
        // Gravity
        if (grounded && Vector3.Dot(velocity, transform.up) < 0) {
            velocity = Vector3.zero;
        }
        velocity += -9.81f * Time.deltaTime * transform.up;
        if (grounded && jump) {
            velocity += Mathf.Sqrt(3f * 9.81f) * transform.up;
        }
        controller.Move(velocity * Time.deltaTime);
        Debug.Log(grounded);
        jump = false;

        // Looking
        var cameraRotation = Quaternion.Euler(new Vector3(cameraAngleX, 0f, 0f));
        Camera.main.transform.localRotation = cameraRotation;
    }

    void OnLook(InputValue value)
    {
        var axisValue = value.Get<Vector2>() * Time.deltaTime;
        transform.Rotate(0, axisValue.x, 0);
        cameraAngleX = Mathf.Clamp(cameraAngleX - axisValue.y, -90f, 90f);
    }

    void OnMove(InputValue value)
    {
        movementInput = value.Get<Vector2>();
    }

    void OnJump(InputValue value) 
    {
        jump = Mathf.RoundToInt(value.Get<float>()) == 1;
    }
}
