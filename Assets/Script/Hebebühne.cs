using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Hebebühne : XRBaseInteractor
{
    // Start is called before the first frame update
    void OnTriggerEnter()
    {
        Debug.Log("Entered");
    }
}
