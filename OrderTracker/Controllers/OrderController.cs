using Microsoft.AspNetCore.Mvc;
using PierresBakery.Models;
using System.Collections.Generic;

namespace PierresBakery.Controllers
{
  public class OrderController : Controller
  {
    [HttpGet("/vendors/{vendorId}/orders/orders{orderId}")] // Notsure about filepath?
    public ActionResult Show(int venderId, int orderId)
    {
      Order Order = Order.Find(orderId); // havent made a method for it yet and it needs to be tested. 
      Vendor Vendor = Vendor.Find(vendorId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("order", order);
      model.Add("vendor", vendor);
      return View(model);
    }
    [HttpGet("/vendors/{vendorId}/orders/new")]
    public ActionResult New(int vendorId)
    {
      Vendor vendor = Vendor.Find(vendorId);
      return View(vendor);
    }

  }
}