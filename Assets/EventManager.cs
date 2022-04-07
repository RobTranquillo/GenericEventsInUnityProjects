using System;
using UnityEngine;
using UnityEngine.Events;


/// <summary>
/// Stellt intern viele wichtige Events bereit,
/// an die sich beliebig rangehangen werden kann und
/// die frei gecalled werden können.
/// </summary>
public class EventManager : MonoBehaviour
{
    public static EventManager current;
    private void Awake()
    {
        current = this;
    }


    //----------- EVENTS TO HOOK ON -----------------------
    public event Action DestroyCube;
    public event Action SpawnCube;

    public event Action GameStart;
    public event Action UpdateCounter;
    public event Action GameOver;


    //----------EVENT TRIGGER THAT CAN BE PULLED ------------------------
    public void Trigger_SpawnCube() { SpawnCube?.Invoke(); }
    public void Trigger_DestroyCube() { DestroyCube?.Invoke(); }

    internal void Trigger_GameStart() { GameStart?.Invoke(); }
    internal void Trigger_UpdateCounter() { UpdateCounter?.Invoke(); }
    internal void Trigger_GameOver() { GameOver?.Invoke(); }
}
