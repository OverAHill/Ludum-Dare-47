using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollide : MonoBehaviour
{
    public string itemName = " ";
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
        GameObject.Find("Player").GetComponent<PlayerObjective>().increaseItemAmount();
        GameObject.Find("Player").GetComponent<PlayerObjective>().AddToList(itemName);

        Object.Destroy(this.gameObject);
    }
}
