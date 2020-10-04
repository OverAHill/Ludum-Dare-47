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
        string ShopList = "Shopping List: \n";
        List<string> list = GameObject.Find("Player").GetComponent<PlayerObjective>().items;

        for (int i = 0; i < 6; i++)
        {
            ShopList = ShopList + list[i] + "\n";
        }

        ListText.text = ShopList; 
    }

    // Update is called once per frame
    void Update()
    {
       // int itemAmount = GameObject.Find("Player").GetComponent<PlayerObjective>().GetItemAmount();
        List<string> list = GameObject.Find("Player").GetComponent<PlayerObjective>().items;

            // ListText.text = itemAmount.ToString();

            string ShopList = "Shopping List: \n";

            foreach (string i in list )
            {
                ShopList = ShopList + i + "\n";
            }

            ListText.text = ShopList;
           // print(itemAmount);
        


    }
}
