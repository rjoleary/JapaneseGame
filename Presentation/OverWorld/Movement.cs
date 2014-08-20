using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour
{
    public float slow = 8.0F;
    public float moderate = 10.0F;
    public float fast = 12.0F;
    public float jump = 10.0F;
    public float gravity = 20.0F;
    public float terminalVelocity = 25.0F;

    private Vector3 moveDirection = Vector3.zero;
    private CharacterController controller;
    private Animator anim;
    private float currentSpeed;

    void Start()
    {
        currentSpeed = slow;
        controller = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        UpdateDirection();
        DecideSpeed();
        UpdateAnimationState();
        controller.Move(moveDirection * Time.deltaTime);
	}

    private void DecideSpeed()
    {
        if (controller.isGrounded && Input.GetButton("Run"))
            currentSpeed = fast;
        else if (Input.GetButton("Run"))
            currentSpeed = slow;
        else 
            currentSpeed = slow;
    }

    private void UpdateDirection()
    {
        var direction = new Vector3(Input.GetAxis("Horizontal"),0,Input.GetAxis("Vertical"));
        direction.Normalize();
        moveDirection = new Vector3(direction.x * currentSpeed, moveDirection.y, direction.z * currentSpeed);
        TryJump();
    }

    private void UpdateAnimationState()
    {
        anim.SetFloat("XZSpeed", IsMovingInXYPlane() ? 0 : currentSpeed);
        anim.SetFloat("YSpeed", moveDirection.y);
    }

    private bool IsMovingInXYPlane() {
        return (Mathf.Abs(Input.GetAxis("Horizontal")) + Mathf.Abs(Input.GetAxis("Vertical"))) == 0;
    }

    private void TryJump() 
    {
        if (controller.isGrounded)
            moveDirection.y = -1*gravity;

        if (controller.isGrounded && Input.GetButton("Jump"))
            moveDirection.y = jump;
        else
        {
            moveDirection.y -= gravity * Time.deltaTime;
            moveDirection.y = Mathf.Max(-1 * terminalVelocity, moveDirection.y);
        }
    }
}
