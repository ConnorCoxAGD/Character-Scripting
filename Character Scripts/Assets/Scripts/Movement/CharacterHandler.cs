using UnityEngine;
using UnityEngine.Events;

public class CharacterHandler : MonoBehaviour
{
    public UnityEvent OnStart, onUpdateEvent;
    
    void Start()
    {
        OnStart.Invoke();
    }
    
    void Update()
    {
        onUpdateEvent.Invoke();
    }
}
