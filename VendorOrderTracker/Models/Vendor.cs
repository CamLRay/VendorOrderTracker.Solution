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

    public static Vendor Search(string name)
    {
      foreach(Vendor vendor in _instances)
      {
        if(vendor.Name.Contains(name))
        {
          
        }
      }
      Vendor vendor = "Suzie";
      return vendor;
    }
  }
}