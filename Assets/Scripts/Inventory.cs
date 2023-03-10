using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using static UnityEditor.Progress;

public class Inventory
{
    Dictionary<EquipSlots, Item> equippedItems = new Dictionary<EquipSlots, Item>();
    List<Item> unequippedItems = new List<Item>();
    private readonly ICharacter character;

    public Inventory(ICharacter character)
    {
        this.character = character;
    }

    public void EquipItem(Item item)
    {
        if(equippedItems.ContainsKey(item.EquipSlot))       
            unequippedItems.Add(equippedItems[item.EquipSlot]);

        equippedItems[item.EquipSlot] = item;
        character.OnItemEquipped(item);
    }

    public Item GetItem(EquipSlots equipSlot)
    {
        if (equippedItems.ContainsKey(equipSlot))
            return equippedItems[equipSlot];

        return null;
    }

    public int GetTotalArmor()
    {
        int totalArmor = equippedItems.Values.Sum(t => t.Armor);
        return totalArmor;
    }
}
