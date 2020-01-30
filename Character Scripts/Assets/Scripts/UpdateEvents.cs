using UnityEngine;
using UnityEngine.Events;

public class UpdateEvents : MonoBehaviour
{
    public UnityEvent onUpdateEvent;

    void Update()
    {
        onUpdateEvent.Invoke();
    }
}
