using System.Collections.Generic;

namespace VendorOrder.Models
{
  public class Orders 
  {
    public string Name { get; set; }
    public string Info { get; set; }
    public string Price { get; set; }
    public string Date { get; set; }
    public int Id {get;}
    private static List<Orders> _instances = new List<Orders> {};

    public Orders (string name, string info, string price, string date)
    {
      Name = name;
      Info = info;
      Price = price;
      Date = date; 
      _instances.Add(this);
      Id = _instances.Count;
    }
    public static List<Orders> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static Orders Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}