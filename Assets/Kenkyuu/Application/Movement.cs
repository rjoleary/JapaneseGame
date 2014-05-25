using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {


    public float walkSpeed = 8.0F;
    public float runSpeed = 12.0F;
    private float speed;

    public float jumpSpeed = 8.0F;
    public float gravity = 20.0F;
    private Vector3 moveDirection = Vector3.zero;
    CharacterController controller;

    void Start(){
        speed = walkSpeed;
        controller = GetComponent<CharacterController>();  
    }

    void Update()
    {
        moveDirection = new Vector3(Input.GetAxis("Horizontal") * speed, moveDirection.y, Input.GetAxis("Vertical") * speed);
        moveDirection = transform.TransformDirection(moveDirection);
        tryJump();
        tryRun();
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
	}

    private void tryJump() 
    {
        if (controller.isGrounded)
            if (Input.GetButton("Jump"))
                moveDirection.y = jumpSpeed;
    }

    private void tryRun()
    {
        if (Input.GetButton("Run"))
            speed = runSpeed;
        else
            speed = walkSpeed;
    }
}
