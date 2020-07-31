using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tankMuzzleRotation : MonoBehaviour
{
    [SerializeField]
    private Transform _cylinder;
    float smooth = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        print(_cylinder.position);
        print(transform.position);
        Vector3 directionToPoint = _cylinder.position - transform.position;
        directionToPoint.x = -90.0f;
        print(directionToPoint);
        print(transform.rotation.eulerAngles);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 directionToPoint = _cylinder.position - transform.position;
        //directionToPoint.x = 270.0f;
        //directionToPoint.z = 0.0f;
        Debug.DrawRay(transform.position, directionToPoint);
        //print("Quaternion: " + Quaternion.LookRotation(directionToPoint).eulerAngles);

        Quaternion target = Quaternion.LookRotation(directionToPoint);
        if (tag == "muzzle")
        {
            //print("This one is indeed a Muzzle!");
            print("target: " + target);
            print(Quaternion.Euler(-90, 0, 0));
        }

        //print("Actual Rotation: " + transform.rotation.eulerAngles);
        
        transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
    }
}
