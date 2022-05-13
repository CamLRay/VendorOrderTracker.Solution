using Microsoft.AspNetCore.Mvc;
using VendorOrderTracker.Models;
using System.Collections.Generic;

namespace VendorOrderTracker.Controllers
{
  public class OrdersController : Controller
    {
      [HttpGet("/orders/{name}")]
      public ActionResult New(string name)
      {
        List<Vendor> allVendors = Vendor.GetAll();
        Vendor foundVendor = Vendor.Find(name);
        return View(foundVendor);
      }
    }
}