using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class EndTrigger : MonoBehaviour
{

    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        //int itemAmount = GameObject.Find("Player").GetComponent<PlayerObjective>().GetItemAmount();

        if (other.gameObject == player)
        {
            print("wuwo");

            if (GameObject.Find("Player").GetComponent<PlayerObjective>().ObjectiveComplete())
            {
                SceneManager.LoadScene("EndMenu");
            }
        }

        
        
    }
}
