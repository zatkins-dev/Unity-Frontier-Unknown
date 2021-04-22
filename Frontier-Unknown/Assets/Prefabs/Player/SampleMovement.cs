using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleMovement : MonoBehaviour
{
    Vector2 horizontalInput;
    [SerializeField] CharacterController controller;
    [SerializeField] float speed = 11f;

    // To simulate gravity down and reset vertical velocity when landing
    [SerializeField] float gravity = -30f;
    Vector3 verticalVelocity = Vector3.zero;
    [SerializeField] LayerMask groundMask;
    bool isGrounded;
    [SerializeField] float jumpHeight = 3.5f;
    bool jump;

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(transform.position, 1.1f, groundMask);
        if (isGrounded)
        {
            verticalVelocity.y = 0;
        }

        Vector3 horizontalVelocity = (transform.right * horizontalInput.x + transform.forward * horizontalInput.y) * speed;
        controller.Move(horizontalVelocity * Time.deltaTime);

        if(jump)
        {
            if (isGrounded)
            {
                print("Grounded!");
                verticalVelocity.y = Mathf.Sqrt(-2f * jumpHeight * gravity);
            }
            else
            {
                print("Def Not Grounded!");
            }
            jump = false;
        }

        verticalVelocity.y += gravity * Time.deltaTime;
        controller.Move(verticalVelocity * Time.deltaTime);
    }

    public void ReceiveInput(Vector2 _horizontalInput)
    {
        horizontalInput = _horizontalInput;
    }

    public void OnJumpPressed()
    {
        jump = true;
    }
}
