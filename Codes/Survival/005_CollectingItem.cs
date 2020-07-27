using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    // type: "void onTriggerEnter" and press enter
    private void OnTriggerEnter(Collider other) // in the setting isTrigger value has been set to true
    {
        //the object(colliding with this.gameObject/ PlayerToMove) needs to be tagged Player otherwise nothing would happen
        if (other.tag == "Player" & other.name == "PlayerToMove") 
        {
            // before destroying the object, on can:
            // add count(poits)
            // change variables and ...
            Destroy(this.gameObject);
        }
        
    }

    //if the isTrigger is not set:
    /*
    private void OnCollisionEnter(Collision collision)
    {
        
    }
    */
}
