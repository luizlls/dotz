using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class GameEvent : ScriptableObject
{
    private List<GameEventListener> listeners = new List<GameEventListener>();

    public void Register(GameEventListener listener)
    {
        listeners.Add(listener);
    }

    public void Remove(GameEventListener listener)
    {
        listeners.Remove(listener);
    }

    public void Raise()
    {
        listeners.ForEach(it => it.OnEventRaised());
    }
}
