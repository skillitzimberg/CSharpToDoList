using System;
using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Item
  {
    private string _description;
    private static List<Item> _itemInstances = new List<Item> {};

    public Item (string description)
    {
      _description = description;
      _itemInstances.Add(this);
    }

    public string GetDescription()
    {
      return _description;
    }

    public void SetDescription(string newDescription)
    {
      _description = newDescription;
    }

    public static List<Item> GetAllItems()
    {
      return _itemInstances;
    }

    public static void ClearAll()
    {
      _itemInstances.Clear();
    }

  }
}
