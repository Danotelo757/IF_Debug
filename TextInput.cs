using UnityEngine;
using UnityEngine.UI;

public class TextInput : MonoBehaviour
{
    public InputField inputField;
    [HideInInspector] public Event Event;
    [HideInInspector] public Action action1, action2;
    string UserInput;
    public float Level;
    GameController controller;
    EventNavigation eventNavigation;
    void Awake()
    {
        controller = GetComponent<GameController>();
        eventNavigation = GetComponent<EventNavigation>();
        inputField.onEndEdit.AddListener(AcceptStringInput);
    }
    public void AcceptStringInput(string userInput)
    {
        userInput = userInput.ToLower();

        //controller.LogStringWithReturn(userInput);

        UserInput = userInput;

        action1.keyString = "1";
        action2.keyString = "2";
        if (UserInput == action1.keyString)
        {
            int.Parse(UserInput);
            controller.LogStringWithReturn("1. " + eventNavigation.presentEvent.actions[0].actionDescription);
            controller.LogStringWithReturn(eventNavigation.presentEvent.actions[0].outcome);
            Debug.Log("You entered a number");
            NullImpact();
        }
        else if (UserInput == action2.keyString)
        {
            int.Parse(UserInput);
            controller.LogStringWithReturn("2. " + eventNavigation.presentEvent.actions[1].actionDescription);
            controller.LogStringWithReturn(eventNavigation.presentEvent.actions[1].outcome);
            Debug.Log("You entered a number");
            NullImpact();
        }
        else
        {
            Debug.Log("You entered a string");
        }
        InputComplete();
    }

    void InputComplete()
    {
        controller.DisplayLoggedText();
        inputField.ActivateInputField();
        inputField.text = null;

    }
    public void NullImpact()
    {
        float impactValue;

        Level = Mathf.Ceil(eventNavigation.presentEvent.eventNum / 3);
        Debug.Log("The current event level is: " + Level);
        for (int i = 0; i < eventNavigation.presentEvent.actions[i].farmerImpactModifier; i++)
        {
            impactValue = eventNavigation.presentEvent.actions[i].farmerImpactModifier * Level;
            Debug.Log("The impactValue of this action is " + impactValue);
        }
        for (int i = 0; i < eventNavigation.presentEvent.actions[i].herderImpactModifier; i++)
        {
            impactValue = eventNavigation.presentEvent.actions[i].herderImpactModifier * Level;
            Debug.Log("The impactValue of this action is " + impactValue);
        }


    }
}
