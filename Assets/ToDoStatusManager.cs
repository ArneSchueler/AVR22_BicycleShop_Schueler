using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToDoStatusManager : MonoBehaviour
{

    [SerializeField]
    public GameObject finishedIcon;
    [SerializeField]
    public GameObject unfinishedIcon;
    
    [SerializeField]
    public GameObject backplate;

    private Color neutralStatusColor = new Color(151, 216, 255,0);


    public ToDoStatus status;
    // Start is called before the first frame update
    void Start()
    {
        status.toDoStatus = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(status.toDoStatus){
            finishedIcon.SetActive(true);
            unfinishedIcon.SetActive(false);
            backplate.GetComponent<RawImage>().color = Color.green;
        }
        else{
            finishedIcon.SetActive(false);
            unfinishedIcon.SetActive(true);
            backplate.GetComponent<RawImage>().color = neutralStatusColor;
        }
        
    }
}
