using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Player : MonoBehaviour
{

    public Vector3 startPosition;


    // Start is called before the first frame update
    void Start()
    {
        //startPosition = new Vector3(0, 0, 0);
        // grab the previous position = (Assign) a new position
        transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
