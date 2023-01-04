using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonRotate : MonoBehaviour
{
    [SerializeField] GameObject plattform;
    private float RotationSpeedInit;
    [SerializeField] private float RotationSpeed;

    private void OnTriggerEnter(Collider other){
        Debug.Log("Trigger Entered");
        RotationSpeedInit = RotationSpeed;
    }

    private void OnTriggerExit(Collider other){
        Debug.Log("Trigger Exited");
        RotationSpeedInit = 0;
    }
    // Start is called before the first frame update
    void Start()
    {
        RotationSpeedInit = 0;

    }

    // Update is called once per frame
    void Update()
    {
        plattform.transform.Rotate(Vector3.up * (RotationSpeedInit * Time.deltaTime));

    }
}
