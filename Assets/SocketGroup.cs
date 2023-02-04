using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.Animations;

public class SocketGroup : MonoBehaviour
{
    [SerializeField] 
    public GameObject portableBike;
    public string tagName;

    ConstraintSource constraintSource;

    Rigidbody m_Rigidbody;

    // Start is called before the first frame update
    void OnTriggerEnter(Collider other){


        Debug.Log("OnTriggerEnter " + other.gameObject.name);

        if(other.gameObject.tag == tagName){
            
            m_Rigidbody = other.gameObject.GetComponent<Rigidbody>();

            other.gameObject.transform.parent = portableBike.transform;

            var parentConstraint = other.gameObject.AddComponent<ParentConstraint>();
            other.attachedRigidbody.useGravity = false;
            m_Rigidbody.constraints = RigidbodyConstraints.FreezeAll;
            m_Rigidbody.mass = 0;

            constraintSource.sourceTransform = portableBike.transform;
            parentConstraint.AddSource(constraintSource);
            //parentConstraint.constraintActive = true;

            
            other.attachedRigidbody.useGravity = false;
            //socket.socketActive = false;
        }
    }
}
