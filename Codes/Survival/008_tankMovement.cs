using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tankMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(horizontalInput, transform.position.y, verticalInput) * 5 * Time.deltaTime);
        transform.Rotate(new Vector3(transform.rotation.x, horizontalInput, transform.rotation.z));

    }
}
