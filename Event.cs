using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Game/Event")]
public class Event : ScriptableObject
{
    [TextArea]
    public string description;
    public string eventName;
    public Action[] actions;
}
