using UnityEngine;

[CreateAssetMenu(menuName = "Instancing/Instance Object")]
public class InstanceObject : ScriptableObject
{  
      public void CreateInstance(GameObject instance)
      {
         Instantiate(instance);
      }
}