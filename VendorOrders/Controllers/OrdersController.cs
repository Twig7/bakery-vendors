using Microsoft.AspNetCore.Mvc;
using VendorOrder.Models;
using System.Collections.Generic;

namespace VendorOrder.Controllers
{
  public class OrdersController : Controller
  {
    [HttpGet("/vendors/{vendorId}/orders/new")]
    public ActionResult New(int vendorId)
    {
      Vendor vendor = Vendor.Find(vendorId);
      return View(vendor);
    }

    [HttpPost("/orders/delete")]
    public ActionResult DeleteAll()
    {
      Orders.ClearAll();
      return View();
    }

    [HttpGet("/vendors/{vendorId}/orders/{orderId}")]
    public ActionResult Show(int vendorId, int orderId)
    {
      Orders orders = Orders.Find(orderId);
      Vendor vendor = Vendor.Find(vendorId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("orders", orders);
      model.Add("vendor", vendor);
      return View(model);
    }
  }
}