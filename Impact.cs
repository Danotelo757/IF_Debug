using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Impact: MonoBehaviour
{
    [HideInInspector] public Event Event;
    [HideInInspector] public Action Action;
    [HideInInspector] public EventNavigation eventNavigation;

    public float Level;

    public void NullImpact(float impactValue)
    {
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
