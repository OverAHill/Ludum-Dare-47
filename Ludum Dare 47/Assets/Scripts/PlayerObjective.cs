using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class PlayerObjective : MonoBehaviour
{

    public List<string> items;
    int itemAmount = 0;
   //public int GetItemAmount() { return items.; }

    // Start is called before the first frame update
    void Start()
    {
        items = new List<string>();
        items.Add("Milk");
        items.Add("Bread");
        items.Add("Cereal");
        items.Add("Cheese");
        items.Add("Apple");
        items.Add("Bean");
    }

    public void RemoveItem(string item)
    {
        items.Remove(item);
        print("remove");
    }

    public bool ObjectiveComplete()
    {
        if (items.Count == 0)
            return true;

        return false;
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
