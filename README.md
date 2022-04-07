Shows how to use generic events in Unity projects.

This events are for script use only but can be uses bound to unity events. 
Take a look in the project scene on the buttons together with the UseEventDirect script.

Event manger provides a static way to access every event and its trigger in a static class
```
public class EventManager : MonoBehaviour
{
    public static EventManager current;
}
```


Every script can attach to the global events
```
    void Start()
    {
        EventManager.current.DestroyCube += OnDestroyCube;
    }
```


And pull the trigger for the event
```
    public void MyFunctionOnAButtonClick()
    {
        EventManager.current.Trigger_DestroyCube();
    }
```

Take a closer look on the 4 tiny scripts in the project to fully understand.