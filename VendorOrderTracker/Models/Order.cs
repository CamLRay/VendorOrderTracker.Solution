using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public int Quantity { get; set; }
    public int Cost { get; set; }
    public int UnitPrice { get; set; } 

    public Order(string title, string description, int quantity, int unitPrice)
    {
      Title = title;
      Description = description;
      Quantity = quantity;
      UnitPrice = unitPrice;
    }

    public int CalcCost()
    {
      Cost = Quantity * UnitPrice;

      return Cost;
    }

  }
}