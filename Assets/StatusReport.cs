using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusReport : MonoBehaviour
{
    public ToDoStatus status;
    public string tagName;
 
    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == tagName){
            status.toDoStatus = true;
        }
    }

    void OnTriggerExit(Collider other){
        if(other.gameObject.tag == tagName){
            status.toDoStatus = false;
        }
    }
}
