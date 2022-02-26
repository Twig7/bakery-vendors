using System.Collections.Generic;

namespace VendorOrder.Models
{
  public class Vendor
  {
    private static List<Vendor> _instances = new List<Vendor> {};
    public string Name { get; set; }
    public string Info { get; set; }
    public int Id { get; }
    public List<Orders> Orders { get; set; }

    public Vendor(string vendorName, string vendorInfo)
    {
      Name = vendorName;
      Info = vendorInfo;
      _instances.Add(this);
      Id = _instances.Count;
      Orders = new List<Orders>{};
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static List<Vendor> GetAll()
    {
      return _instances;
    }
    public static Vendor Find(int searchId)
    {
      return _instances[searchId-1];
    }
    public void AddOrder(Orders orders)
    {
      Orders.Add(orders);
    }
  }
}