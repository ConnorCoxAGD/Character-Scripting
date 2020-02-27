using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerMoveBehaviour : MonoBehaviour
{
    public float speed = 5f;
    private Vector3 _direction;
    private CharacterController _controller;
    public void Start()
    {
        _controller = GetComponent<CharacterController>();
    }
    public void Update()
    {
        PlayerMovement();
    }
    void PlayerMovement()
    {
        _direction.x = Input.GetAxis("Horizontal");
        _direction.z = Input.GetAxis("Vertical");
        
        Vector3 movement = new Vector3(_direction.x, 0.0f, _direction.z);

        if (movement != Vector3.zero)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation,
                Quaternion.LookRotation(movement), 0.15F);
        }

        transform.Translate (movement * speed * Time.deltaTime, Space.World);
    }
}
