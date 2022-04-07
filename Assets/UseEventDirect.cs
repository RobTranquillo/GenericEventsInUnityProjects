using System.Collections;
using System.Collections.Generic;
using UnityEngine;




/// <summary>
/// This class shows both ways to use the generic event system
/// First way ist to use pull the trigger of an event explicit in your code like: EventManager.current.Trigger_DestroyCube();
/// Second way is to Build one Scipt like this one that contains all possible events that can be triggerd.
/// This can be use on every object and bound one Unity-Event to one of this internal events.
/// </summary>
public class UseEventDirect : MonoBehaviour
{
    public void DestroyCube()
    {
        // you can trigger what ever event you want from where ever you want
        EventManager.current.Trigger_DestroyCube();
    }
    
    public void SpawnCube()
    {
        // you can trigger what ever event you want from where ever you want
        EventManager.current.Trigger_SpawnCube();
    }
}
