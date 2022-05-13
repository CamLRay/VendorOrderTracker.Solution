using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrderTracker.Models;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class VendorTests
  {
    [TestMethod]
    public void VendorConstructor_CreateInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("Suzie's Cafe");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "Pierre Duex";
      Vendor newVendor = new Vendor(name);
      string result = newVendor.Name;

      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void Search_ReturnsCorrectVendors_Vendor()
    {
      Vendor newVendor1 = new Vendor("Suzie's Cafe");
      Vendor newVendor2 = new Vendor("Suzie's Second Cafe");
      Vendor newVendor3 = new Vendor("Pierre Duex");

      Vendor result = Vendor.Search("Pierre");

      Assert.AreEqual(newVendor3, result);
    }
  }
}