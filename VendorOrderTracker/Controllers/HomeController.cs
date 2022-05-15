using Microsoft.AspNetCore.Mvc;
using VendorOrderTracker.Models;

namespace VendorOrderTracker.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

      [HttpPost("/")]
      public ActionResult Create(string name, string description)
      {
        Vendor newVendor = new Vendor(name, description);
        return RedirectToAction("Index");
      }

      [HttpPost("/mock")]
      public ActionResult Create()
      {
        Vendor newVendor = new Vendor("Suzie's Cafe", "Small Southern Kitchen");
        Vendor newVendor1 = new Vendor("Petrucci's Parlor", "New York style pizzaria");
        Vendor newVendor2 = new Vendor("Debs", "Coffee Shop");
        Vendor newVendor3 = new Vendor("Donny's", "New England Deli");
        Vendor newVendor4 = new Vendor("Bob's Burgers", "Smash burgers and more");

        return RedirectToAction("Index");
      }

    }
}