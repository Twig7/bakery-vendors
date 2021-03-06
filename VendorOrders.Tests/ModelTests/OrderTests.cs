using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrder.Models;
using System;
using System.Collections.Generic;

namespace VendorOrder.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {

    public void Dispose()
    {
      Orders.ClearAll();
    }
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Orders newOrder = new Orders("Bagels", "3 Bagels", "A high five", "10/08/2019");
      Assert.AreEqual(typeof(Orders), newOrder.GetType());
    }
    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      List<Orders> newList = new List<Orders> { };
      List<Orders> result = Orders.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      string ordername = "Too many bagels";
      string orderinfo = "Who keeps letting her buy this many";
      Orders newOrder = new Orders(ordername, orderinfo, "$2", "orderDate");
      List<Orders> newList = new List<Orders> { newOrder };
      List<Orders> result = Orders.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      string info1 = "How many bagels?";
      string info2 = "A normal amount of bagels";
      Orders newOrder1 = new Orders(info1, "orderName", "$2", "orderDate");
      Orders newOrder2 = new Orders (info2, "orderName2", "$1", "orderDate2");
      Orders result = Orders.Find(2);
      Assert.AreEqual(newOrder2, result);
    }
  }
}