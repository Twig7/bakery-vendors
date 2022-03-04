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
  }
}