using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
   float steerSpeed = 250;
   float moveSpeed = 20;
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {      float steerAmountX = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
           float moveAmountY = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
           transform.Rotate(0, 0, -steerAmountX); // Rotate on center of object
           transform.Translate(0, moveAmountY, 0); // Move
    }
}
