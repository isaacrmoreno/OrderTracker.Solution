using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.TestTools
{
  [TestClass]
  public class OrderTest : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("Max's Muffins", "Needs lots of rye bread", 3, 1 / 10 / 1997);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void GetOrderTitle_ReturnsOrderTitle_String()
    {
      string orderTitle = "Max's Muffins";
      Order newOrder = new Order(orderTitle, "Needs lots of rye bread", 3, 1 / 10 / 1997);
      string result = newOrder.Title;
      Assert.AreEqual(orderTitle, result);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string description = "Needs lots of bread";
      Order newOrder = new Order("Max's Muffins", description, 3, 1 / 10 / 1997);
      string result = newOrder.Description;
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void GetPrice_ReturnsPrice_Int()
    {

      int price = 3;
      Order newOrder = new Order("Max's Muffins", "Needs lots of rye bread", price, 1 / 10 / 1997);

      int result = newOrder.Price;

      Assert.AreEqual(price, result);
    }

    [TestMethod]
    public void GetDate_ReturnsDate_String()
    {

      int date = 1 / 10 / 1997;
      Order newOrder = new Order("Max's Muffins", "Needs lots of rye bread", 3, date);

      int result = newOrder.Date;

      Assert.AreEqual(date, result);
    }

    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      Order newOrder1 = new Order("Max's Muffins", "Needs lots of rye bread", 3, 1 / 10 / 1997);
      Order newOrder2 = new Order("Sally's Scones", "Toast Baguettes to a Crisp", 4, 2 / 7 / 1995);
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
  }
}