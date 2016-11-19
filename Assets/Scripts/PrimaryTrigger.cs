using UnityEngine;
using System.Collections;

public class PrimaryTrigger : MonoBehaviour {

    void OnTriggerEnter(Collider collider)
    {
        //Debug.Log("PrimaryTrigger " + collider);
        SecondaryTrigger trigger = GetComponentInChildren<SecondaryTrigger>();
        //this sets the collider field in SecondayTrigger
        // then secondary trigger can test on its collider enter
        //   if the ball that went through the top was the same ball that 
        //   is triggering the bottom of the net collider
        trigger.ExpectCollider(collider);
    }

}
