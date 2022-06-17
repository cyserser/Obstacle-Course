using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    MeshRenderer myMeshRenderer;


    void Awake()
    {
        myMeshRenderer = GetComponent<MeshRenderer>();
    }

    void OnCollisionEnter(Collision other) 
    {    
        if(other.gameObject.tag == "Player")
        {
            gameObject.tag = "Hit";
            myMeshRenderer.material.color = Color.red;
        }
    }
}
