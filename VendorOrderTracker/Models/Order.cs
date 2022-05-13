using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public int Quantity { get; set; }
    public int Cost { get; set; }

    public Order(string title, string description, int quantity)
    {
      Title = title;
      Description = description;
      Quantity = quantity;
    }

    public int CalcCost(int unitPrice)
    {
      Cost = Quantity * unitPrice;

      return Cost;
    }

  }
}