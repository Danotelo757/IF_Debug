using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventNavigation : MonoBehaviour
{
    [HideInInspector] public Event Event;
    public Event presentEvent;
    Dictionary<string, Event> actionDictionary = new Dictionary<string, Event>();

    GameController controller;

    void Awake()
    {
        controller = GetComponent<GameController>();
    }

    public void ListPossibleActions()
    {
        for (int i = 0; i < presentEvent.actions.Length; i++)
        {
            actionDictionary.Add(presentEvent.actions[i].keyString, presentEvent.actions[i].nextEvent);
            controller.possibleEventActions.Add(presentEvent.actions[i].actionDescription);
        }
    }

    public void ClearActions()
    {
        actionDictionary.Clear();
    }
}