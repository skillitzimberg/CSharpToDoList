using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using ToDoList.Models;

namespace ToDoList.Tests
{
  [TestClass]
  public class ItemTest : IDisposable
  {

    public void Dispose()
    {
      Item.ClearAll();
    }

    [TestMethod]
    public void ItemConstructor_CreatesInstanceOfItem_Item()
    {
      Item newItem = new Item("test");
      Assert.AreEqual(typeof(Item), newItem.GetType());
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      //Arrange
      string description = "Walk the dog.";
      Item newItem = new Item(description);

      //Act
      string result = newItem.GetDescription();

      //Assert
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      //Arrange
      string description = "Walk the dog.";
      Item newItem = new Item(description);

      //Act
      string updatedDescription = "Do the dishes";
      newItem.SetDescription(updatedDescription);
      string result = newItem.GetDescription();

      //Assert
      Assert.AreEqual(updatedDescription, result);
    }

    [TestMethod]
    public void GetAllItems_ReturnsEmptyList_ListWithNoItems()
    {
      List<Item> newList = new List<Item> {};

      List<Item> result = Item.GetAllItems();
      foreach (Item thisItem in result)
      {
        Console.WriteLine("Output from empty list GetAllItems test: " + thisItem.GetDescription());
      }

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAllItems_ReturnsPopulatedList_ListOfItems()
    {
      string descriptionOne = "Do a thing";
      string descriptionTwo = "Do another thing";
      Item newItemOne = new Item(descriptionOne);
      Item newItemTwo = new Item(descriptionTwo);
      List<Item> newList = new List<Item> { newItemOne, newItemTwo };

      List<Item> result = Item.GetAllItems();
      foreach (Item thisItem in result)
      {
        Console.WriteLine("Output from second list GetAllItems test: " + thisItem.GetDescription());
      }

      CollectionAssert.AreEqual(newList, result);
    }

  }
}
