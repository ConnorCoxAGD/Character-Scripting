using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class CharacterMove : CharacterBase
{
    public override void Move()
    {
        Location.Set(Input.GetAxis("Horizontal") * speed, 0 , Input.GetAxis("Vertical") * speed);
        
        if (Controller.isGrounded && Input.GetButton("Jump"))
        {
            Location.y = jumpSpeed * Time.deltaTime;
        }
        else
        {
            Location.y += gravity * Time.deltaTime;  
        }
        
        Location = Controller.transform.TransformDirection(Location);
        
        var mouseInput = Input.GetAxis("Mouse X");
        Orientation = new Vector3(0,mouseInput,0);
        Controller.transform.Rotate(Orientation);
        
        if (Input.GetMouseButtonDown(0))
            Cursor.lockState = CursorLockMode.Locked;
        Controller.Move(Location * Time.deltaTime);
    }
}