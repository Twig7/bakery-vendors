using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorOrder.Models;
using System;

namespace VendorOrder.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }
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
      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void GetAll_ReturnsAllVendors_VendorList()
    {
      string name1 = "Ella";
      string name2 = "Twig";
      Vendor newVendor1 = new Vendor(name1, "info1");
      Vendor newVendor2 = new Vendor(name2, "info2");
      List<Vendor> newVendorList = new List<Vendor> {newVendor1, newVendor2};
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newVendorList, result);
    }
  }
}
