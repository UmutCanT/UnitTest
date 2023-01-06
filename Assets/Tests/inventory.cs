using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using NSubstitute;

public class inventory 
{
    [Test]
    public void Only_allows_one_chest_to_be_equipped_at_a_time()
    {
        //ARRANGE
        ICharacter character = Substitute.For<ICharacter>();
        Inventory inventory = new Inventory(character);
        Item chestOne = new Item() { EquipSlot = EquipSlots.Chest };
        Item chestTwo = new Item() { EquipSlot = EquipSlots.Chest };

        //ACT
        inventory.EquipItem(chestOne);
        inventory.EquipItem(chestTwo);

        //ASSERT
        Item equippedItem = inventory.GetItem(EquipSlots.Chest);
        Assert.AreEqual(chestTwo, equippedItem);
    }
    
    [Test]
    public void Tells_character_when_an_item_is_equipped_successfully()
    {
        //ARRANGE
        ICharacter character = Substitute.For<ICharacter>();
        Inventory inventory = new Inventory(character);
        Item chestOne = new Item() { EquipSlot = EquipSlots.Chest };      

        //ACT
        inventory.EquipItem(chestOne);

        //ASSERT
        character.Received().OnItemEquipped(chestOne);
    }
}
