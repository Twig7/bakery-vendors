using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorOrder.Models;
using System;

namespace VendorOrder.Tests
{
  [TestClass]
  public class VendorTests
  {
    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "Test Name";
      string info = "Test Info";
      Vendor newVendor = new Vendor(name, info);
      string result = newVendor.Name;
      Assert.AreEqual(name, result);
    }
    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      string name = "Test Vendor";
      string info = "Test Info";
      Vendor newVendor = new Vendor(name, info);
      int result = newVendor.Id;
      Assert.AreEqual(2, result);
    }
    [TestMethod]
    public void AddOrder_AssociatesOrderWithVendor_OrderList()
    {
      string orderName = "Ella";
      string orderInfo = "Kiddo";
      string price = "Priceless";
      string date = "10/08/2019";
      Orders newOrder = new Orders(orderName, orderInfo, price, date);
      List<Orders> newList = new List<Orders> {newOrder};
      string vendorName = "Ella's Bakery";
      Vendor newVendor = new Vendor(vendorName, VendorInfo);
      newVendor.AddOrder(newOrder);
      List<Orders> result = newVendor.Orders;
      CollectionAssert.AreEqual(newList, result);
    }
  }
}
