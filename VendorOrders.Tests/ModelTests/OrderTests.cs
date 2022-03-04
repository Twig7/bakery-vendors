using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrder.Models;
using System;
using System.Collections.Generic;

namespace VendorOrder.Tests

{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Orders newOrder = new Orders("Bagels", "3 Bagels", "A high five", "10/08/2019");
      Assert.AreEqual(typeof(Orders), newOrder.GetType());
    }
  }
}