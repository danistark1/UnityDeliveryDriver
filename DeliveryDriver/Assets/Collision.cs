using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("Ouch!!!!");
        
    }

     void OnTriggerEnter2D(Collider2D other) {
         Debug.Log("Entered Zone 66");
        
    }

    void OnTriggerExit2D(Collider2D other) {
        Debug.Log("Left Zone 66");
    }
}
