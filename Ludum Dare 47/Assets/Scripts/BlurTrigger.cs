using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlurTrigger : MonoBehaviour
{

    public float blur;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CameraShader camera = GameObject.Find("Main Camera").GetComponent<CameraShader>();
        camera.BlurSize = blur;

    }

    private void OnTriggerEnter(Collider other)
    {
        blur = 0.0f;


        // print("ahhh");
    }

    private void OnTriggerExit(Collider other)
    {
        blur = 0.1f;

    }
}
