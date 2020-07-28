using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crate : MonoBehaviour
{

    public GameObject fracturedCrate;
    //public GameObject explosionEffect;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.X))
        {

            //Instantiate(explosionEffect, transform.position, Quaternion.identity);
            //Destroy(this.gameObject);
           
            //make this gameObject extra small
            transform.localScale = new Vector3(.001f, .001f, .001f);
            
            // Set the position of the the game object and create it(create it if disabled)
            GameObject fracturedCrateObj = Instantiate(fracturedCrate, transform.position, Quaternion.identity) as GameObject;
            
            //find all the children in the GameObject
            Rigidbody[] allRigidBodies = fracturedCrateObj.GetComponentsInChildren<Rigidbody>(); 

            //checking to see if there are any childrens in this GameObject
            if (allRigidBodies.Length > 0)
            {
                foreach(var body in allRigidBodies)
                {
                    body.useGravity = true; //enables the gravity option
                    body.AddExplosionForce(1500, transform.position, 10); //creates an explosion effect
                }
            }
        }
        
    }
}
