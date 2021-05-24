using UnityEngine;

public class FPSMovement : MonoBehaviour
{
    
    public float xSpeed, zSpeed, gravity;
    private CharacterController _controller;
    private Vector3 _position;
    private void Start()
    {
        _controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        _position.Set(Input.GetAxis("Horizontal") * xSpeed, -gravity * Time.deltaTime, Input.GetAxis("Vertical") * zSpeed);
      
        _position = _controller.transform.TransformDirection(_position);
        _controller.Move(_position * Time.deltaTime);
    }
}
