using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzzKata;
using FizzBuzzKata.Handlers;

namespace FizzBuzzKataTest {
  [TestClass]
  public class FizzBuzzPatternTest {

    private FizzBuzzKata.FizzBuzzPattern fbp;

    [TestInitialize]
    public void Init() {
      fbp = new FizzBuzzKata.FizzBuzzPattern(FizzBuzzBusinessRules.GetHandlers());
    }

    [TestCleanup]
    public void Cleanup() {
      fbp = null;
    }


    [TestMethod]
    public void NumberTest() {
      Assert.AreEqual("Odd", fbp.Process(1));
      Assert.AreEqual("Odd", fbp.Process(7));
      Assert.AreEqual("Odd", fbp.Process(11));
      Assert.AreEqual("Odd", fbp.Process(13));
    }

    [TestMethod]
    public void FizzTest() {
      Assert.AreEqual("Fizz", fbp.Process(3));
      Assert.AreEqual("Fizz", fbp.Process(6));
      Assert.AreEqual("Fizz", fbp.Process(9));
    }

    [TestMethod]
    public void BuzzTest() {
      Assert.AreEqual("Buzz", fbp.Process(5));
      Assert.AreEqual("Buzz", fbp.Process(10));
    }

    [TestMethod]
    public void FizzBuzzTest() {
      Assert.AreEqual("FizzBuzz", fbp.Process(15));
    }

    [TestMethod]
    public void FizzfuzzTest() {
      Assert.AreEqual("FizzFuzz", fbp.Process(12));
    }

    [TestMethod]
    public void RangeTest() {
      var result = fbp.ProcessRange(1, 100);
      Assert.AreEqual("Odd", result.Substring(0, 3));
      Assert.AreEqual("Buzz", result.Substring(result.Length - 4, 4));
    }

    [TestMethod]
    public void EvenTest() {
      Assert.AreEqual("Even", fbp.Process(2));
      Assert.AreEqual("Even", fbp.Process(4));
      Assert.AreEqual("Even", fbp.Process(8));
      Assert.AreEqual("Even", fbp.Process(14));
    }

    [TestMethod]
    public void OddTest() {
      Assert.AreEqual("Odd", fbp.Process(1));
      Assert.AreEqual("Odd", fbp.Process(7));
    }

    [TestMethod]
    public void EvenOddHandlerTest() {
      var handlers = new List<IInputHandler>() {
        new EvenHandler(),
        new OddHandler(),
        new DefaultHandler()
      };
      var lfbp = new FizzBuzzPattern(handlers);
      Assert.AreEqual("Odd", lfbp.Process(1));
      Assert.AreEqual("Even", lfbp.Process(2));
      Assert.AreEqual("Odd", lfbp.Process(3));
      Assert.AreEqual("Even", lfbp.Process(4));
      Assert.AreEqual("Odd", lfbp.Process(5));
    }
  }
}
