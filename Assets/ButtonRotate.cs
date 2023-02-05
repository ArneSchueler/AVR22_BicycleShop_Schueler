using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonRotate : MonoBehaviour
{
    [SerializeField] GameObject plattform;
    private float RotationSpeedInit;
    [SerializeField] private float RotationSpeed;

    public void StartRotation( ){
        RotationSpeedInit = RotationSpeed;
    }

    public void StopRotation(){
        RotationSpeedInit = 0;
    }

    // Update is called once per frame
    void Update()
    {
        plattform.transform.Rotate(Vector3.up * (RotationSpeedInit * Time.deltaTime));

    }
}
