using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
   float steerSpeed = 250;
   float moveSpeed = 20;

   [SerializeField] float slowSpeed = 10f;
   [SerializeField] float boostSpeed = 60f;

    // Start is called before the first frame update
    void Start()
    {
     
    }

    void OnTriggerEnter2D(Collider2D other) {
    if (other.tag == "Slow Speed") {
       moveSpeed = slowSpeed;
    }
    if (other.tag == "Boost Speed") {
       moveSpeed = boostSpeed;
    }
    }

    // Update is called once per frame
    void Update()
    {      float steerAmountX = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
           float moveAmountY = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
           transform.Rotate(0, 0, -steerAmountX); // Rotate on center of object
           transform.Translate(0, moveAmountY, 0); // Move
    }
}
