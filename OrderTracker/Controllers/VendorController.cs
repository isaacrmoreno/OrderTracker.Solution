using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PierresBakery.Models;
using System;

namespace PierresBakery.Controllers
{
  public class VendorController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }
    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vendors")]
    public ActionResult Create(string vendorName, string description)
    {
      Vendor newVendor = new(vendorName, description);
      return RedirectToAction("Index");
    }
    [HttpGet("/vendors/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new();
      Vendor selectedVendor = Vendor.Find(id);
      List<Order> VendorOrders = selectedVendor.Orders;
      model.Add("vendor", selectedVendor);
      model.Add("orders", VendorOrders);
      return View(model);
    }
    [HttpPost("/vendors/{vendorId}/orders")]
    public ActionResult Create(int vendorId, string title, string description, int price, int date)
    {
      Dictionary<string, object> model = new();
      Vendor foundVendor = Vendor.Find(vendorId);
      Order newOrder = new(title, description, price, date);
      foundVendor.AddOrder(newOrder);
      List<Order> vendorOrders = foundVendor.Orders;
      model.Add("orders", vendorOrders);
      model.Add("vendor", foundVendor);
      return View("Show", model);
    }
  }
}