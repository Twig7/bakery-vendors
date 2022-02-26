using Microsoft.AspNetCore.Mvc;

namespace VendorOrder.Controllers
{
  public class StartController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}