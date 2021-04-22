using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPController : MonoBehaviour
{
    public enum GravityMode { point, directional, surface }
    Camera fpCam;
    CharacterController fpController;
    GravityMode currentGravityMode;
    [SerializeField] float moveSpeed, lookSpeed;
    [SerializeField] float appliedGravity, jumpForce;
    Vector3 gravityDirection;
    Vector3 moveDirection;
    Collider gravitySource;

    float xRot;
    // Start is called before the first frame update
    void Start()
    {
        fpCam = GetComponentInChildren<Camera>();
        fpController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 moveIn = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        Vector2 lookIn = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));
        Move(moveIn);
        Look(lookIn);
        
    }

    void GravityCheck()
    {
        switch(currentGravityMode)
        {
            case GravityMode.directional:
                gravityDirection = gravityDirection = -transform.up;
                break;
            case GravityMode.surface:
                gravityDirection = gravitySource.ClosestPoint(transform.position) - transform.position;
                break;
            default:
                gravityDirection = gravitySource.transform.position - transform.position;
                break;
        }
    }

    void Move(Vector2 input)
    {
        if (fpController.isGrounded)
        {
            moveDirection = transform.right * input.x + transform.forward * input.y;
            moveDirection.Normalize();
            moveDirection *= moveSpeed;
            transform.TransformDirection(moveDirection);
            if (Input.GetButtonDown("Jump")) UpdateJump();
        }
        else
        {
            moveDirection -= transform.up * appliedGravity * Time.deltaTime;
        }

        fpController.Move(moveDirection * Time.deltaTime);
    }

    void UpdateJump()
    {
        moveDirection += transform.up * jumpForce;
    }

    void Look(Vector2 input)
    {
        transform.Rotate(transform.up * input.x * lookSpeed);
        xRot = Mathf.Clamp(xRot - input.y, -80f, 80f);
        fpCam.transform.localRotation = Quaternion.Euler(xRot, 0f, 0f);
    }

    public void UpdateGravityDirection(Vector3 downVector)
    {
        transform.LookAt(transform.forward, -downVector);
    }
}
