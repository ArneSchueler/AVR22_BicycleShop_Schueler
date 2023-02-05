using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHydraulic : MonoBehaviour
{
    public float speed = 2f;
    public bool activeUp;

    public void activateUp(){
        activeUp = true;
    }

    public void deactivateUp(){
        activeUp = false;
    }

    public void MoveUp(){
            transform.Translate(0f, 0f,speed * Time.deltaTime);

    }

    public void MoveDown(){
        transform.Translate(0f, 0f,-speed * Time.deltaTime);
    }

}
