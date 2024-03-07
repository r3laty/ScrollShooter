using System;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<Item> InventoryItems;

    public static Action<Item> ItemAdded;
    
    private static Inventory _instance;
    private void Start()
    {
        _instance = this;   
    }

    public static void AddItem(Item item)
    {
        _instance.InventoryItems.Clear();

        _instance.InventoryItems.Add(item);

        ItemAdded?.Invoke(item);
    }
}
