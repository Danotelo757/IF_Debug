using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventNavigation : MonoBehaviour
{
    public Event presentEvent;
    Dictionary<string, Event> actionDictionary = new Dictionary<string, Event>();

    GameController controller;

    private void Awake()
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


    void AttemptToProceed(string actionNoun)
    {
        if (actionDictionary.ContainsKey(actionNoun))
        {
            presentEvent = actionDictionary[actionNoun];
            controller.LogStringWithReturn("You chose to " + actionNoun);
            
            controller.DisplayEventText();
        }
        else
        {
            controller.LogStringWithReturn("There is no action like " + actionNoun);
        }
    }
    public void ClearActions()
    {
        actionDictionary.Clear();
    }

    //void DisplayOutcome(string outcome)
    //{
    //    action.outcome = outcome
    //}
}
    