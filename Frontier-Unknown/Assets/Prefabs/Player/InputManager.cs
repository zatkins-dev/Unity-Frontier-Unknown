using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    [SerializeField] SampleMovement movement;
    [SerializeField] SampleMouseLook mouseLook;
    SamplePlayerControls controls;
    SamplePlayerControls.GroundMovementActions groundMovement;
    Vector2 horizontalInput;
    Vector2 mouseInput;

    private void Awake()
    {
        Cursor.lockState = CursorLockMode.Confined;
        controls = new SamplePlayerControls();
        groundMovement = controls.GroundMovement;
        groundMovement.HorizontalMovement.performed += ctx => horizontalInput = ctx.ReadValue<Vector2>();
        groundMovement.Jump.performed += _ => movement.OnJumpPressed();
        groundMovement.MouseX.performed += ctx => mouseInput.x = ctx.ReadValue<float>();
        groundMovement.MouseY.performed += ctx => mouseInput.y = ctx.ReadValue<float>();
    }

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }


    // Update is called once per frame
    private void Update()
    {
        movement.ReceiveInput(horizontalInput);
        mouseLook.ReceiveInput(mouseInput);
    }
}
