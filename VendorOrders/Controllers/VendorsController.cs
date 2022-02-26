using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using VendorOrder.Models;

namespace VendorOrder.Controllers
{
  public class VendorsController : Controller 
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }
    [HttpGet("/venders/new")]
    public ActionResult New()
    {
      return View();
    }
    [HttpPost("/vendors")]
    public ActionResult Create(string vendorName, string vendorInfo)
    {
      Vendor newVendor = new Vendor(vendorName, vendorInfo);
      return RedirectToAction("Start");
    }
    [HttpGet("/vendors/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> models = new Dictionary<string, object>();
      Vendor selectedVendor = Vendor.Find(id);
      List<Orders> vendorOrders = selectedVendor.Orders;
      models.Add("vendor", selectedVendor);
      models.Add("orders", vendorOrders);
      return View(models);
    }
    [HttpPost("/vendors/{vendorId}/orders")]
    public ActionResult Create(int vendorId, string orderName, string orderInfo, string orderPrice, string orderDate)
    {
      Dictionary<string, object> models = new Dictionary<string, object>();
      Vendor foundVendor = Vendor.Find(vendorId);
      Orders newOrder = new Orders(orderName, orderInfo, orderPrice, orderDate);
      foundVendor.AddOrder(newOrder);
      List<Orders> vendorOrder = foundVendor.Orders;
      models.Add("orders", vendorOrder);
      models.Add("vendor", foundVendor);
      return View("Show", models);
    }
  }
}