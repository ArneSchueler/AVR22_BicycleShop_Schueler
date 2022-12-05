using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debugger : MonoBehaviour
{

    public string testObject;

    // Start is called before the first frame update
    void Start()
    {
        UnityEngine.Debug.Log(testObject + " was created");
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
