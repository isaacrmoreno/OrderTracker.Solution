using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Order
  {
    private static List<Order> _instances = new List<Order> { };
    public string Title { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public int Date { get; set; }
    public int Id { get; }
    public Order(string description)
    {
      Description = description;
      _instances.Add(this);
      Id = _instances.Count;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}