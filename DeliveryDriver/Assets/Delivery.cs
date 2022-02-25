using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    public bool picked = false;
    public bool delivered = false;
    public bool shouldDeliver = false;
    [SerializeField] Color32 hasColor32 = new Color32 (2, 207, 1, 255);
    [SerializeField] Color32 noPackageColor = new Color32 (1, 1, 1, 1);

    SpriteRenderer spriteRenderer;

    void Start() {
       spriteRenderer = GetComponent<SpriteRenderer>(); 
    }
    void OnCollisionEnter2D(Collision2D other) {
     //   Debug.Log("Ouch!!!!");
        
    }

     void OnTriggerEnter2D(Collider2D other) {
         if (other.tag == "Package" && !shouldDeliver) {
             spriteRenderer.color = hasColor32;
             Destroy(other.gameObject, 0.5f);
             Debug.Log("Package Picked Up!");
             picked = true;
             shouldDeliver = true;
        
         }

         if (other.tag == "Location" && picked && shouldDeliver) {
             spriteRenderer.color = noPackageColor;
             Debug.Log("Package Delivered!");
             delivered = true;
             shouldDeliver = false;
         }
         if (other.tag == "Location" && !picked) {
             Debug.Log("You haven't picked a package yet!");
         }
    }

    void OnTriggerExit2D(Collider2D other) {
        //Debug.Log("Left Zone 66");
    }
}
