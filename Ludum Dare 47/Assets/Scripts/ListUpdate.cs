using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ListUpdate : MonoBehaviour
{
    //public GameObject player;
    public Text ListText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int itemAmount = GameObject.Find("Player").GetComponent<PlayerObjective>().GetItemAmount();
        List<string> list = GameObject.Find("Player").GetComponent<PlayerObjective>().items;

        if (itemAmount != 0)
        {
           // ListText.text = itemAmount.ToString();

            string ShopList = "Shopping List \n";

            for(int i = 0; i <itemAmount; i++)
            {
                ShopList = ShopList + list[i] + "\n";
            }

            ListText.text = ShopList;

        }


    }
}
