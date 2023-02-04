using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ToDoStatus", menuName = "ToDoStatus")]
public class ToDoStatus : ScriptableObject
{
    public string toDoName;
    public bool toDoStatus = false;
}
