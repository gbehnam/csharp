using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Input.GetKey
        //Input.GetKeyUp
        //Input.GetKeyDown


        if (Input.GetKeyDown("g")) // keys should be lower case
        {
            print("g was pressed!"); //print is the same as Debug.Log it prints to the console
        }
        
        
        if (Input.GetKeyDown(KeyCode.Space)) // list of all the available keys in KeyCode
        {
            Debug.Log("the space key was pressed this time!"); // print to the console
        }


        if (Input.GetKey(KeyCode.E))
        {
            Debug.Log("The E key is being held down!");
        }


        if (Input.GetKeyUp(KeyCode.H))
        {
            Debug.Log("The H key has just been lifted!");
        }
    }
}
