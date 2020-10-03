using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float forwardForce = 20f;
    public float sidewaysForce = 20f;


    public Transform cameraPos;
    public Vector3 forwardForceVector;
    public Vector3 sideForceVector;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {

        forwardForceVector = transform.position - cameraPos.position;
        forwardForceVector.y = transform.position.y;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        forwardForceVector.Normalize();
        forwardForceVector = forwardForceVector* forwardForce * Time.deltaTime;
        sideForceVector = Vector3.Cross(forwardForceVector, Vector3.up);

        //= new Vector3(20f * Time.deltaTime, 0, 0);
        //forward force vector based on camera facing direction
        //but flattened 

        if (Input.GetKey("d"))
        {
           // -forwardForce* Time.deltaTime, 0, 0
            GetComponent<Rigidbody>().AddForce(-sideForceVector, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            // forwardForce* Time.deltaTime, 0, 0

            GetComponent<Rigidbody>().AddForce(sideForceVector, ForceMode.VelocityChange);
        }

        if (Input.GetKey("w"))
        {
            //0, 0, sidewaysForce * Time.deltaTime
            GetComponent<Rigidbody>().AddForce(forwardForceVector, ForceMode.VelocityChange);
        }

        if (Input.GetKey("s"))
        {
            //0, 0, -sidewaysForce * Time.deltaTime
            GetComponent<Rigidbody>().AddForce(-forwardForceVector, ForceMode.VelocityChange);
        }


    }
}
