using UnityEngine;

public class CharControlScheme : MonoBehaviour
{
   public float Speed = 1f, JumpSpeed = 1f, Gravity = -0.5f;

   private CharacterController _controller;
   private Vector3 _pos;
   private Vector3 _orientation;
    
   void Start()
   {
      _controller = GetComponent<CharacterController>();
   }

   void Update()
   {
      if (_controller.isGrounded && Input.GetButton("Jump"))
      {
         _pos.y += JumpSpeed * Time.deltaTime;
      }
      else
      {
         _pos.y += Gravity * Time.deltaTime;  
      }
      
      _pos.Set(Input.GetAxis("Horizontal") * Speed * Time.deltaTime, 0, 0);
      _pos.z = Input.GetAxis("Vertical") * Speed * Time.deltaTime;
      
      var mouseInput = Input.GetAxis("Mouse X");
      _orientation = new Vector3(0,mouseInput,0);
      _controller.transform.Rotate(_orientation);
      _pos = _controller.transform.TransformDirection(_pos);
      
      
      if (Input.GetMouseButtonDown(0))
         Cursor.lockState = CursorLockMode.Locked;
      _controller.Move(_pos);

   }
}