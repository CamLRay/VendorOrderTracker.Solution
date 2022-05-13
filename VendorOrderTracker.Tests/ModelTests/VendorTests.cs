using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrderTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

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
    public void Search_ReturnsCorrectVendor_Vendor()
    {
      Vendor newVendor1 = new Vendor("Suzie's Cafe");
      Vendor newVendor2 = new Vendor("Suzie's Second Cafe");
      Vendor newVendor3 = new Vendor("Pierre Duex");

      List<Vendor> resultList = Vendor.Search("Pierre");
      Vendor result = resultList[0];

      Assert.AreEqual(newVendor3, result);
    }

    [TestMethod]
    public void Search_ReturnsCorrectVendors_List()
    {
      Vendor newVendor1 = new Vendor("Suzie's Cafe");
      Vendor newVendor2 = new Vendor("Suzie's Second Cafe");
      Vendor newVendor3 = new Vendor("Pierre Duex");

      List<Vendor> tempList = new List<Vendor> {};
      tempList.Add(newVendor1);
      tempList.Add(newVendor2);
      List<Vendor> resultList = Vendor.Search("Suzie");
      
      CollectionAssert.AreEqual(tempList, resultList);
    }

    [TestMethod]
    public void GetAll_ReturnListOfVendors_List()
    {
      Vendor newVendor1 = new Vendor("Suzie's Cafe");
      Vendor newVendor2 = new Vendor("Suzie's Second Cafe");
      Vendor newVendor3 = new Vendor("Pierre Duex");

      List<Vendor> tempList = new List<Vendor> {};
      tempList.Add(newVendor1);
      tempList.Add(newVendor2);
      tempList.Add(newVendor3);

      List<Vendor> resultList = Vendor.GetAll();
      CollectionAssert.AreEqual(tempList, resultList);
    }

    [TestMethod]
    public void AddOrder_AddsOrderToVendorOrderList_List()
    {
      Vendor newVendor = new Vendor("Suzie's Cafe");
      Order newOrder = new Order("Sourdough", "Sliced loaf", 1, 5);
      newVendor.Orders.Add(newOrder);

      Assert.AreEqual(newVendor.Orders[0], newOrder);
    }

    [TestMethod]
    public void Production_ProductionFromVendor_int()
    {
      Vendor newVendor = new Vendor("Suzie's Cafe");
      Order newOrder = new Order("Sourdough", "Sliced loaf", 1, 5);
      Order newOrder2 = new Order("Rye", "Sliced loaf", 1, 3);
      newVendor.Orders.Add(newOrder);
      newVendor.Orders.Add(newOrder2);
      int production = newVendor.Production();

      Assert.AreEqual(8, production);
    }
  }
}