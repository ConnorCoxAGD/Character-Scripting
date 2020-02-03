using UnityEngine;
[CreateAssetMenu]
public class MoveForwardRotate : CharacterBase
{
    public override void Move()
    {
        position.Set(0, 0, Input.GetAxis("Vertical") * speed);
        orientation.Set(0, Input.GetAxis("Horizontal") * orientSpeed, 0);

        position = Controller.transform.TransformDirection(position);
        Controller.Move(position * Time.deltaTime);
        Controller.transform.Rotate(orientation * Time.deltaTime);
    }
}
