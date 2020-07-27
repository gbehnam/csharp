using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]  //this will add a field in unity editor
    private float _speed;

    [SerializeField]
    private float _horizontalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // move the object to the right, change the speed by converting the change based on frame to change based on time 
        //transform.Translate(Vector3.right * Time.deltaTime); 


        //              new Vector3(1, 0, 0) * speed(set in the editor) * real time
        //transform.Translate(Vector3.right * _speed * Time.deltaTime);

        // map the value to horizontal keys left and right arrows as well as "a" and "d"
        float horizontalInput = Input.GetAxis("Horizontal");

        _horizontalInput = Input.GetAxis("Horizontal"); //created just to see the actual input value
        float verticalInput = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(horizontalInput, verticalInput, 0) * _speed * Time.deltaTime);

    }
}
