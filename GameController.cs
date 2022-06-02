using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Text displayText;
    [HideInInspector] public EventNavigation eventNavigation;
    [HideInInspector] public Action action;
    [HideInInspector] public List<string> possibleEventActions = new List<string>();

    List<string> actionLog = new List<string>();
    // Start is called before the first frame update

    void Awake()
    {
        eventNavigation = GetComponent<EventNavigation>();
    }

    void Start()
    {
        DisplayEventText();
        DisplayLoggedText();
    }
    public void DisplayLoggedText()
    {
        string logAsText = string.Join("\n", actionLog.ToArray());
        displayText.text = logAsText;
    }

    public void DisplayEventText()
    {
        ClearCollectionsForNewEvent();
        ListActions();
        string joinedActionDescriptions = string.Join("\n", possibleEventActions.ToArray());
        string outcomeText = action.outcome;
        string combinedText = eventNavigation.presentEvent.description + "\n\n" + joinedActionDescriptions + outcomeText;

        LogStringWithReturn(combinedText);
        LogStringWithReturn(outcomeText);
        Debug.Log(outcomeText);
    }

    public void ListActions()
    {
        eventNavigation.ListPossibleActions();
    }

    void ClearCollectionsForNewEvent()
    {
        possibleEventActions.Clear();
        eventNavigation.ClearActions();
    }

    public void LogStringWithReturn(string stringToAdd)
    {
        actionLog.Add(stringToAdd + "\n");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
