using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hangman.Models;

namespace PierresBakery.TestTools
{
  [TestClass]
  public class OrderVendorTest
  {
    [TestMethod]
    public void GameConstructor_CreatesInstanceOfHangmanGame_HangmanGame()
    {
      HangmanGame newHangman = new();
      Assert.AreEqual(typeof(HangmanGame), newHangman.GetType());
    }
  }
}