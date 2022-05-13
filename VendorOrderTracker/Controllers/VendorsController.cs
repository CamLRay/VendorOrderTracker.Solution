using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VendorOrderTracker.Models;

namespace VendorOrderTracker.Controllers
{
  public class VendorsController : Controller
    {
      [HttpGet("/vendors")]
      public ActionResult Index()
      {
        List<Vendor> allVendors = Vendor.GetAll();
        return View(allVendors);
      }

      [HttpPost("/vendors")]
      public ActionResult Create(string name)
      {
        Vendor newVendor = new Vendor(name);
        return RedirectToAction("Index");
      }

      [HttpGet("/vendors/{vendor}")]
      public ActionResult Show(Vendor vendor)
      {
        List<Vendor> allVendors = Vendor.GetAll();
        Vendor foundVendor = Vendor.Find(vendor);
        return View(foundVendor);
      }

    }
}