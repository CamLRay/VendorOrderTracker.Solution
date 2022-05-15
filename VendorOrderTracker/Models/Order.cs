using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
  public class Order
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public int Quantity { get; set; }
    public string Date { get; set; }
    public int Cost { get; set; }
    public int UnitPrice { get; set; } 

    public Order(string name, string description, int quantity, string date, int unitPrice)
    {
      Name = name;
      Description = description;
      Quantity = quantity;
      UnitPrice = unitPrice;
      Date = date;
      Cost = quantity * unitPrice;
    }

  }
}