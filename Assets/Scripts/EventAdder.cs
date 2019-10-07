using System;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public static class EventAdder
{
    public static void AddOnClick(this Button button, Action onClickAction)
    {
        var eventEntry = new EventTrigger.Entry()
        {
            eventID = EventTriggerType.PointerDown
        };

        eventEntry.callback.AddListener(delegate(BaseEventData bed)
        {
            onClickAction();
        });
        
        var eventTrigger = button.gameObject.GetComponent<EventTrigger>();
        if(eventTrigger == null)
            eventTrigger = button.gameObject.AddComponent<EventTrigger>();

        eventTrigger.triggers.Add(eventEntry);
    }
}
