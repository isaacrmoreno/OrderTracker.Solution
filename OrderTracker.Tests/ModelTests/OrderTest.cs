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
    {
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test order");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
  }
}
}