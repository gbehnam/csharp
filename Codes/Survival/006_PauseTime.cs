using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{

    private float speedRate = 0.1F;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.P))
        {
            // stop/pause the time
            Time.timeScale = 0; //the default is 1 and smaller values mean slow motion
        }else if (Input.GetKeyDown(KeyCode.R))
        {
            // resume the time with like normal 
            Time.timeScale = 1;
        }else if (Input.GetKey(KeyCode.F))
        {
            //make the time go faster
            Time.timeScale += speedRate;
        }
        else if (Input.GetKey(KeyCode.N))
        {
            //make the time go slower
            if (Time.timeScale >= 0)
            {
                Time.timeScale -= speedRate;
            }
            
        }
        
    }
}
