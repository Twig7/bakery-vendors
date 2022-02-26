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
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor pickedVendor = Vendor.Find(id);
      List<Order> VendorOrder = selectedVendor.Order;
      model.Add("vendor", pickedVendor);
      model.Add("order", VendorOrder);
      return View(model);
    }
    [HttpPost("/vendors/{vendorId}/orders")]
    public ActionResult Create(int vendorId, string orderName, string orderInfo, string OrderPrices, string orderDate)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor foundVendor = Vendor.Find(vendorId);
      Order newOrder = new Order(orderName, orderInfo, orderPrice, orderDate);
      foundVendor.AddOrder(newOrder);
      List<Order> vendorOrder = foundVendor.Orders;
      model.Add("orders", vendorOrder);
      model.Add("vendor", foundVendor);
      return View("Show", model);
    }
  }
}