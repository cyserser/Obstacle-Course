using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    [SerializeField] int score = 1;

    void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.tag != "Hit")
        {   
            Debug.Log("You have bumped: " + score + " times");
            score++;
        }
        
    }
}
