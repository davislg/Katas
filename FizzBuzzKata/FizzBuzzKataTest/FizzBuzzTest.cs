using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzKataTest {
  [TestClass]
  public class FizzBuzzTest {

    private FizzBuzzKata.FizzBuzz fb;

    [TestInitialize]
    public void Init() {
      fb = new FizzBuzzKata.FizzBuzz();
    }

    [TestCleanup]
    public void Cleanup() {
      fb = null;
    }

    [TestMethod]
    public void NumberTest() {
      Assert.AreEqual("1", fb.Do(1));
    }

    [TestMethod]
    public void FizzTest() {
      Assert.AreEqual("Fizz", fb.Do(3));
    }

    [TestMethod]
    public void BuzzTest() {
      Assert.AreEqual("Buzz", fb.Do(5));
    }

    [TestMethod]
    public void FizzBuzz() {
      Assert.AreEqual("FizzBuzz", fb.Do(15));
    }

    [TestMethod]
    public void RangeTest() {
      Assert.AreEqual("1,Even,Fizz,Even,Buzz,Even,7,Even,Fizz,Even,11,Even,13,Even,FizzBuzz", fb.DoRange(1, 15));

      var result = fb.DoRange(1, 100);
      Assert.AreEqual("1", result.Substring(0, 1));
      Assert.AreEqual("Even", result.Substring(result.Length-4, 4));
    }

    [TestMethod]
    public void EvenTest() {
      Assert.AreEqual("Even", fb.Do(2));
      Assert.AreEqual("Even", fb.Do(4));
    }

  }
}
