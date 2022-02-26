using System.Collections.Generic;

namespace VendorOrder.Models
{
  public class Vendor 
  {
    public string Name { get; set; }
    public string Info { get; set; }
    public string Price { get; set; }
    public string Date { get; set; }
    public int Id {get;}
    private static List<Order> _instances = new List<Order> {};

    public Order (string name, string info, string price, string date)
    {
      Name = name;
      Info = info;
      Price = price;
      Date = date; 
      _instances.Add(this);
      Id = _instances.Count;
    }
    public static List<Order> GetAll()
    {
      return _isntances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static Order Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}