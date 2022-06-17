using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeToWait = 3f;

    MeshRenderer myMeshRenderer;
    Rigidbody myRigidbody;


    void Awake()
    {
       myMeshRenderer = GetComponent<MeshRenderer>();
       myRigidbody = GetComponent<Rigidbody>(); 
    }
    void Start()
    {
       myMeshRenderer.enabled = false;
       myRigidbody.useGravity = false;
    }

    void Update()
    {
        if(Time.time > timeToWait)
        {
            myMeshRenderer.enabled = true;
            myRigidbody.useGravity = true;
        }
    }

    
}
