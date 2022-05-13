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

      [HttpGet("/vendors/{vendorName}")]
      public ActionResult Show(string vendorName)
      {
        List<Vendor> allVendors = Vendor.GetAll();
        Vendor foundVendor = Vendor.Find(vendorName);
        return View(foundVendor);
      }

    }
}