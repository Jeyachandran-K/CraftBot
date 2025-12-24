
using System.Collections.Generic;
using UnityEngine;

public class Inventory 
{
    private List<Item> itemsList;

    public Inventory()
    {
        itemsList = new List<Item>();
        itemsList.Add(new Item() { itemType = Item.ItemType.RedCube, amount =1});
        itemsList.Add(new Item() { itemType = Item.ItemType.GreenCube, amount =1});
        Debug.Log(itemsList.Count);
    }
}
