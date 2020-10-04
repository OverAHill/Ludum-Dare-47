using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class PlayerObjective : MonoBehaviour
{

    public List<string> items;
    int itemAmount = 0;
    public int GetItemAmount() { return itemAmount; }

    // Start is called before the first frame update
    void Start()
    {
        items = new List<string>();
        //add at start
        //make function to remove from list and change teh iteraction from "ListUpdate.cs"
    }

    public void increaseItemAmount()
    {
        itemAmount++;
        print(itemAmount);
    }

    public void AddToList(string name)
    {
        items.Add(name);
        print(items[0]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
