using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;

public class ClickButton : MonoBehaviour
{
    // This script is added to a gameObject for example main camera
    // Main camera is then assigned to on Click() part of a button
    // then the functions could be selected

    int initialNumber = 100;
    int reduce10 = 10;
    int add15 = 15;

    void Start()
    {

    }
   
    public void Reduce() 
    {
        initialNumber -= reduce10;
        initialNumber -= RandomNumber(false);
        Debug.Log("new number after reduction: " + initialNumber);
    }

    public void Add()
    {
        initialNumber += add15;
        initialNumber += RandomNumber(true);
        Debug.Log("new number afer addition: " + initialNumber);
    }

    private int RandomNumber(Boolean big)
    {
        if (big)
        {
            return UnityEngine.Random.Range(0, 50);
        }
        else
        {
            return UnityEngine.Random.Range(7, 20);
        }
    }

    

}
