
using System;
using System.Collections.Generic;
using UnityEngine;

public class Inventory 
{
    public event Action OnItemAdded;
    private List<Item> itemsList;

    public Inventory()
    {
        itemsList = new List<Item>();
        Debug.Log(itemsList.Count);
    }

    private void AddItem(Item item)
    {
        itemsList.Add(item);
        OnItemAdded?.Invoke();

    }

    public List<Item> GetItemList()
    {
        return itemsList;
    }
}
