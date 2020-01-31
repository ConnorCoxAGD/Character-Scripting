using UnityEngine;
[CreateAssetMenu]
public class CharacterMove : CharacterBase
{
    public override void Move()
    {
        position.Set(Input.GetAxis("Horizontal") * speed, 0, Input.GetAxis("Vertical") * speed);
        orientation.Set(0, Input.GetAxis("Mouse X") * orientSpeed, 0);

        Cursor.lockState = CursorLockMode.Locked;

        position = Controller.transform.TransformDirection(position);
        Controller.Move(position * Time.deltaTime);
        Controller.transform.Rotate(orientation * Time.deltaTime);
    }
}