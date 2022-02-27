using System.Collections.Generic;

namespace VendorOrder.Models
{
  public class Orders 
  {
    public string Ordername { get; set; }
    public string Orderinfo { get; set; }
    public string Price { get; set; }
    public string Date { get; set; }
    public int Id {get;}
    private static List<Orders> _instances = new List<Orders> {};

    public Orders (string orderName, string orderInfo, string price, string date)
    {
      Ordername = orderName;
      Orderinfo = orderInfo;
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