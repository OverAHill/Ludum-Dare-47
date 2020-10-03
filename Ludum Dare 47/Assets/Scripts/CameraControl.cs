using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public float forwardForce = 10f;
    public float sidewaysForce = 10f;

    public Transform player;
    public Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Rotate around the player
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.RotateAround(player.position, Vector3.up, -20 * Time.deltaTime);
            offset = transform.position - player.position;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.RotateAround(player.position, Vector3.up, 20 * Time.deltaTime);
            offset = transform.position - player.position;

        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
           
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            
        }

    }

    private void Update()
    {
        transform.position = player.position + offset;

      // print(transform.rotation);
    }
}
