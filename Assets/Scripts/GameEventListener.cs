using UnityEngine;
using UnityEngine.Events;

public class GameEventListener : MonoBehaviour
{
    [SerializeField]
    GameEvent gameEvent;

    [SerializeField]
    UnityEvent unityEvent;

    void OnEnable()
    {
        gameEvent.Register(this);
    }

    void OnDisable()
    {
        gameEvent.Remove(this);
    }

    public void OnEventRaised()
    {
        unityEvent.Invoke();
    }
}
