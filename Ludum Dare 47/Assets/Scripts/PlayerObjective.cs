using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class PlayerObjective : MonoBehaviour
{

    List<string> items;
    float itemAmount = 0f;

    // Start is called before the first frame update
    void Start()
    {
        items = new List<string>();
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
