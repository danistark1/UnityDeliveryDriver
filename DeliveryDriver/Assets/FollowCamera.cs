using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject thingToFollow;
    // Late update so that there is no delay between camera/car positioning
    // Late update happens later, (after update)
    void LateUpdate()
    {   // change camera position to be on top of the car, added the vecot (z position -10 to correct camera position)
        transform.position = thingToFollow.transform.position + new Vector3 (0,0,-10);
    }
}
