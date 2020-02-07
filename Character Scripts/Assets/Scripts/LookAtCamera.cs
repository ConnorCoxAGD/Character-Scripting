using UnityEngine;

public class LookAtCamera : MonoBehaviour 
{
    public GameObject target;
     
    private void LateUpdate() 
    {
        transform.LookAt(target.transform);
    }
}