using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHydraulic : MonoBehaviour
{
    public float speed = 0.5f;
    private Vector3 highPosition = new Vector3(-0.114f, 1.778f, 0.002f);
    private Vector3 lowPosition = new Vector3(-0.114f, 0.889f, 0.002f);


    private bool activeUp = false;
    private bool activeDown = false;
    private bool wasActivated = false;


    
    public void ActivateMoveUp(){
        activeUp = true;
    }

    public void DectivateMoveUp(){
        activeUp = false;
    }

    public void ActivateMoveDown(){
        activeDown = true;
    }

    public void DectivateMoveDown(){
        activeDown = false;
    }

    void Update(){
    
        if (activeUp && transform.position.y < highPosition.y){
            transform.Translate(0f, 0f,speed * Time.deltaTime);
        }     

        if (activeDown && transform.position.y > lowPosition.y){
            transform.Translate(0f, 0f,-1 * speed * Time.deltaTime);
        }  
    }

}
