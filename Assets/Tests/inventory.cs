using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class inventory 
{
    [Test]
    public void Only_allows_one_chest_to_be_equipped_at_a_time()
    {
        //ARRANGE
        Inventory inventory = new Inventory();
        Item chestOne = new Item() { EquipSlot = EquipSlots.Chest };
        Item chestTwo = new Item() { EquipSlot = EquipSlots.Chest };

        //ACT
        inventory.EquipItem(chestOne);
        inventory.EquipItem(chestTwo);

        //ASSERT
        Item equippedItem = inventory.GetItem(EquipSlots.Chest);
        Assert.AreEqual(chestTwo, equippedItem);
    }
}
