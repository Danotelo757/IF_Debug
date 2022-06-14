using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Game/Event")]
public class Event : ScriptableObject
{
    public float eventNum;
    [TextArea]
    public string description;
    public string eventName;
    public Action[] actions;
}