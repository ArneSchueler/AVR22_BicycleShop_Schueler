using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.Animations;

public class SocketGroup : MonoBehaviour
{
    [SerializeField] 
    public GameObject bicycleAssembly;

    public string tagName;
    private bool triggered;

    ConstraintSource constraintSource;

    Rigidbody m_Rigidbody;

    // Start is called before the first frame update
    void OnTriggerEnter(Collider other){


        if(other.gameObject.tag == tagName){
            
            //m_Rigidbody = other.gameObject.GetComponent<Rigidbody>();
            Debug.Log("OnTriggerEnter " + other.gameObject.name);
            other.gameObject.transform.parent = bicycleAssembly.transform;

            // var parentConstraint = other.gameObject.AddComponent<ParentConstraint>();
            // other.attachedRigidbody.useGravity = false;
            // m_Rigidbody.constraints = RigidbodyConstraints.FreezeAll;
            // //m_Rigidbody.mass = 0;

            // constraintSource.sourceTransform = bicycleAssembly.transform;
            // parentConstraint.AddSource(constraintSource);
            // parentConstraint.constraintActive = true;

            
            //other.attachedRigidbody.useGravity = false;
            //socket.socketActive = false;
        }
    }

    void OnTriggerExit(Collider other){
            other.attachedRigidbody.useGravity = true;
            m_Rigidbody.constraints = RigidbodyConstraints.None;

    }
}
