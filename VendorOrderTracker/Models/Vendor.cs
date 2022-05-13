using System.Collections.Generic;


namespace VendorOrderTracker.Models
{
  public class Vendor
  {
    private static List<Vendor> _instances = new List<Vendor> {};
    public string Name { get; set; }
    public List<Order> Orders { get; set; }
    public int Production { get; set; }

    
    public Vendor(string name)
    {
      Name = name;
      _instances.Add(this);
      Orders = new List<Order> {};
    }

    public static List<Vendor> Search(string name)
    {
      List<Vendor> searchedVendors = new List<Vendor> {};
      foreach(Vendor vendor in _instances)
      {
        if(vendor.Name.Contains(name))
        {
          searchedVendors.Add(vendor);
        }
      }
      
      return searchedVendors;
    }

    public static Vendor Find(string vendorName)
    {
      int elementIndex = 0;
      foreach(Vendor vendor in _instances)
      {
        if(vendor.Name == vendorName)
          {
            elementIndex = _instances.IndexOf(vendor);
          }
      }
      return _instances[elementIndex];
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public void CalcProduction()
    {
      
      foreach(Order order in Orders)
      {
        Production += order.Cost;
      }
      
    }

    public static List<Vendor> GetAll()
    {
      return _instances;
    }

    // public void AddOrder(Order order)
    // {
    //   order.CalcCost();
    //   Orders.Add(order);
    // }
  }
}