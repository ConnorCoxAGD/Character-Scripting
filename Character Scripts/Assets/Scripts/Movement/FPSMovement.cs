using UnityEngine;

public class FPSMovement : MonoBehaviour
{
    public float walkingSpeed = 10, 
        runningSpeed = 20, 
        jumpForce = 15,
        groundDistance = -.4f;
    public Transform groundCheck;

    private CharacterController cc;
    private Vector3 verticalVelocity, previousMoveVector;
    private bool isGrounded;
    private float currentSpeed;

    private void Start(){
        cc = GetComponent<CharacterController>();
    }

    private void Update(){
        //checks if controller is grounded more accurately than CharacterController
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance);
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        
        //resets fall speed while grounded
        if (isGrounded && verticalVelocity.y < 0){
            verticalVelocity.y = 0f;
        }
        Vector3 movement = transform.right * x + transform.forward * z;

        //allows sprint
        if(Input.GetKey(KeyCode.LeftShift) && !isGrounded){
            currentSpeed = runningSpeed;
        }
        else{
            currentSpeed = walkingSpeed;
        }

        if(!isGrounded){
            previousMoveVector = Vector3.MoveTowards(previousMoveVector, movement, 1.5f * Time.deltaTime);
            cc.Move(previousMoveVector * currentSpeed * Time.deltaTime);
        }
        else{
            previousMoveVector = movement;
            cc.Move(movement * currentSpeed * Time.deltaTime);
        }
        

        //jump
        if(Input.GetButtonDown("Jump") && isGrounded){
            verticalVelocity.y += Mathf.Sqrt(jumpForce * -2f * Physics.gravity.y);
            print("jump");
        }

        verticalVelocity.y += Physics.gravity.y * Time.deltaTime;
        cc.Move(verticalVelocity * Time.deltaTime);
    }
}
