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

      [HttpGet("/vendors/{name}")]
      public ActionResult Show(string name)
      {
        List<Vendor> allVendors = Vendor.GetAll();
        Vendor foundVendor = Vendor.Find(name);
        return View(foundVendor);
      }

      [HttpPost("/vendors/{name}/orders")]
      public ActionResult Create(string name, string description, int quantity, int unitPrice)
      {
        return RedirectToAction("Show");
      }
    }
}