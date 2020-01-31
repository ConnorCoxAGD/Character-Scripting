using UnityEngine;

public abstract class CharacterBase : ScriptableObject
{
    public CharacterController Controller { get; set; }
    protected Vector3 position;
    protected Vector3 orientation;
    public float speed = 3f, orientSpeed = 5f;
    
    public abstract void Move();

}