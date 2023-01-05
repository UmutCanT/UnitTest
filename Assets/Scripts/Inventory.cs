using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Inventory
{
    Dictionary<EquipSlots, Item> equippedItems = new Dictionary<EquipSlots, Item>();
    List<Item> unequippedItems = new List<Item>();

    public void EquipedItem(Item item)
    {
        if(equippedItems.ContainsKey(item.EquipSlot))       
            unequippedItems.Add(equippedItems[item.EquipSlot]);

        equippedItems[item.EquipSlot] = item;
    }

    public float GetTotalArmor()
    {
        int totalArmor = equippedItems.Values.Sum(t => t.Armor);
        return totalArmor;
    }
}
