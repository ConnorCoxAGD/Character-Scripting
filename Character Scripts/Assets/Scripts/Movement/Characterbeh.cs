using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpControls : MonoBehaviour
{
    public float jumpSpeed = 10f, gravity = 10f;

    public CharacterController Controller;
    private Vector3 _position;

    public void Start()
    {
        Controller = GetComponent<CharacterController>();
    }

    public void Update()
    {
        _position.y -= gravity;

        if (Controller.isGrounded && Input.GetButtonDown("Jump"))
        {
            _position.y = jumpSpeed;
        }

        Controller.Move(_position * Time.deltaTime);

    }
}
