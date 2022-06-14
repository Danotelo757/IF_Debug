using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Action
{
    public string keyString;
    public string actionDescription;
    public int farmerImpactModifier;
    public int herderImpactModifier;
    [TextArea]
    public string outcome;
    public Event nextEvent;
}
