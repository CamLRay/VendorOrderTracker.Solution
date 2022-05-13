using Microsoft.AspNetCore.Mvc;

namespace VendorOrderTracker.Controllers
{
  public class OrdersController : Controller
    {
      [HttpGet("/orders/{name}")]
      public ActionResult New()
      {
        return View();
      }
    }
}