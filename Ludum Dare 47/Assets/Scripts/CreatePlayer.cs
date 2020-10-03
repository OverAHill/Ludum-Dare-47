using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePlayer : MonoBehaviour
{

    Vector3 offset = new Vector3(-5, 0, 0);
    // Start is called before the first frame update
    void Start()
    {
        Vector3 newPos = transform.position + offset;
        GameObject.Find("Player").GetComponent<PlayerMovement>().SetPosition(newPos);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
