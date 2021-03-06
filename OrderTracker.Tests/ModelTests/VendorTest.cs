using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class VendorTest : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("Bills Baguettes", "Expedite Shipping");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
    [TestMethod]
    public void GetVendorName_ReturnsName_String()
    {
      string name = "Bills Baguettes";
      Vendor newVender = new Vendor(name, "Expedite Shipping");
      string result = newVender.Name;
      Assert.AreEqual(name, result);
    }
    [TestMethod]
    public void GetId_ReturnsVendorId_int()
    {
      string name = "Claire's Cupcakes";
      Vendor newVendor = new Vendor(name, "Add Extra Frosting");
      int result = newVendor.Id;
      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_Vendorlist()
    {
      string name1 = "Bill Baguettes";
      string name2 = "Claire's Cupcakes";
      Vendor newVender1 = new Vendor(name1, "Expedite Shipping");
      Vendor newVender2 = new Vendor(name2, "Add Extra Frosting");
      List<Vendor> newList = new List<Vendor> { newVender1, newVender2 };
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void Find_ReturnsSpecificVendor_Vendor()
    {
      string name1 = "Bill Baguettes";
      string name2 = "Claire's Cupcakes";
      Vendor newVender1 = new Vendor(name1, "Expedite Shipping");
      Vendor newVender2 = new Vendor(name2, "Add Extra Frosting");
      Vendor result = Vendor.Find(2);
      Assert.AreEqual(newVender2, result);
    }
    [TestMethod]
    public void AddOrder_AssociatesOrderWithVendor_OrderList()
    {

      string description = "Needs 5 loafs of bread";
      Order newOrder = new Order("Max's Muffins", description, 3, 1 / 10 / 1997);
      List<Order> newList = new List<Order> { newOrder };
      string name = "Max's Muffins";
      Vendor newVendor = new Vendor(name, "Muffins on Sale");
      newVendor.AddOrder(newOrder);
      List<Order> result = newVendor.Orders;
      CollectionAssert.AreEqual(newList, result);
    }
  }

}