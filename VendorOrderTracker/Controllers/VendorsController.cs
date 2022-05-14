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
        Vendor.CalcProduction();
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
        
        Vendor foundVendor = Vendor.Find(name);
        return View(foundVendor);
      }

      [HttpPost("/vendors/{vendorName}/orders")]
      public ActionResult Create(string vendorName, string name, string description, int quantity, int unitPrice)
      {
        Order newOrder = new Order(name, description, quantity, unitPrice);

        Vendor foundVendor = Vendor.Find(vendorName);
        foundVendor.Orders.Add(newOrder);
        return View("Show", foundVendor);
      }
    }
}