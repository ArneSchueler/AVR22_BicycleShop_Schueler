using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Transformers;

public class assembleBicycle : MonoBehaviour
{
    [SerializeField]
    public GameObject bicycleAssembly;
    [SerializeField]
    public GameObject frameSocket;
    [SerializeField]
    public GameObject seatSocket;
    [SerializeField]
    public GameObject handlebarSocket;
    [SerializeField]
    public GameObject seatpoleSocket;


    public void Assemble(){
        if (bicycleAssembly.transform.childCount < 3){
            Debug.Log("Bicycle cant be assembled");
        }
        else{

            Debug.Log("Bicycle assembled");
            bicycleAssembly.transform.position = new Vector3(-0.615f, 0.915f, -0.589f);
            
            SceneManager.SetActiveScene(SceneManager.GetSceneByName("Workstation_3x3"));
            GameObject portableBicycle = Instantiate(bicycleAssembly);
            Debug.Log("After Inst: " + bicycleAssembly.transform.position);

            portableBicycle.name = "portableBicycle";
            //portableBicycle.transform.position = new Vector3(-0.615f, 0.915f, -0.589f);
            Debug.Log("Position after Instatiation: " + portableBicycle.transform.position);

            for (int i = bicycleAssembly.transform.childCount-1; i>=0; i--){
                GameObject child = bicycleAssembly.transform.GetChild(i).gameObject;
                
                for (int j = portableBicycle.transform.childCount-1; j>=0; j--){
                    GameObject childNew = portableBicycle.transform.GetChild(i).gameObject;
                    childNew.transform.position = child.transform.position;
                }

                Destroy(child);
                Debug.Log(child.name);
            }

            bicycleAssembly.SetActive(false);

            for (int i = 0; i<portableBicycle.transform.childCount; i++){
                GameObject child = portableBicycle.transform.GetChild(i).gameObject;
                Debug.Log(child +" " + child.transform.position);
                            
                Debug.Log(child.name);
                child.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
                Destroy(child.GetComponent<XRGrabInteractable>());
                Destroy(child.GetComponent<Rigidbody>());
                Destroy(child.GetComponent<MeshCollider>());
                Destroy(child.GetComponent<BoxCollider>());
                Destroy(child.GetComponent<XRSingleGrabFreeTransformer>());

                // child.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
                // child.GetComponent<XRGrabInteractable>().enabled = false;
                // child.GetComponent<Rigidbody>().useGravity = false;
                // child.GetComponent<MeshCollider>().enabled = false;
            }

            portableBicycle.GetComponent<BoxCollider>().enabled = true;
            Debug.Log("Position after BoxCollider: " + portableBicycle.transform.position);

            portableBicycle.GetComponent<XRGrabInteractable>().enabled = true;
            Debug.Log("Position after Grab: " + portableBicycle.transform.position);

            portableBicycle.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            Debug.Log("Position after Rigid: " + portableBicycle.transform.position);
        }
    }
}
