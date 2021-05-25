using UnityEngine;

public class FPSMovement : MonoBehaviour
{
    
    public float speed, jumpForce;
    private CharacterController controller;
    private Vector3 moveVector = Vector3.zero;
    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        //sets movement vector
        
        moveVector.Set(Input.GetAxis("Horizontal") * speed, moveVector.y, Input.GetAxis("Vertical") * speed);
        moveVector = controller.transform.TransformDirection(moveVector);
        //adds gravity
        if(!controller.isGrounded){
            moveVector.y = Physics.gravity.y;
        }
        //adds Jump
        if(controller.isGrounded && Input.GetKeyDown(KeyCode.Space)){
            moveVector.y = jumpForce;
            print(moveVector.y);
        }

        print(moveVector);


        controller.Move(moveVector * Time.deltaTime);
    }
}
