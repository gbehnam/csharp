using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class SwitchTest : MonoBehaviour
{
    // Start is called before the first frame update
    private int _keySelected = 5;
    public GameObject cube;
    public int points;

    void Start()
    {
        StartCoroutine(AddTwentyPointsEverySecond());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Z))
        {
            _keySelected = 1;
        } else if (Input.GetKeyUp(KeyCode.X))
        {
            _keySelected = 2;
        } else if (Input.GetKeyUp(KeyCode.C))
        {
            _keySelected = 3;
        } else if (Input.GetKeyUp(KeyCode.V))
        {
            _keySelected = 4;
        } 

        switch (_keySelected)
        {
            case 1:
                cube.GetComponent<Renderer>().material.color = UnityEngine.Color.yellow;
                break;
            case 2:
                cube.GetComponent<Renderer>().material.color = UnityEngine.Color.blue;
                break;
            case 3:
                cube.GetComponent<Renderer>().material.color = UnityEngine.Color.cyan;
                break;
            case 4:
                cube.GetComponent<Renderer>().material.color = UnityEngine.Color.red;
                break;
            default:
                cube.GetComponent<Renderer>().material.color = UnityEngine.Color.black;
                break;
        }

        Debug.Log("The current point is: " + points);
        
    }


    IEnumerator AddTwentyPointsEverySecond()
    {
        for (int i=100; i >=0; i -= 2)
        {
            points += 20;
            yield return new WaitForSeconds(1.0f);
        }
        
        
    }
}
