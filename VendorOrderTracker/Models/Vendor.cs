using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
  public class Vendor
  {
    private static List<Vendor> _instances = new List<Vendor> {};
    public string Name { get; set; }
    

    public Vendor(string name)
    {
      Name = name;
      _instances.Add(this);
      
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

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}