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
      Vendor newVendor = new Vendor("test vendor");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
    [TestMethod]
    public void GetVendorName_ReturnsName_String()
    {
      string name = "Bills Baguettes";
      Vendor newVender = new Vendor(name);
      string result = newVender.Name;
      Assert.AreEqual(name, result);
    }
    [TestMethod]
    public void GetId_ReturnsVendorId_int()
    {
      string name = "Claire's Cupcakes";
      Vendor newVendor = new Vendor(name);
      int result = newVendor.Id;
      Assert.AreEqual(1, result);
    }
  }
}