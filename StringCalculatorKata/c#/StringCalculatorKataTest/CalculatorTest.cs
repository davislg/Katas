using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringCalculatorKata;

namespace StringCalculatorKataTest {
  [TestClass]
  public class CalculatorTest {

    private Calculator calc;

    [TestInitialize]
    public void Init() {
      calc = new Calculator();
    }

    [TestCleanup]
    public void Cleanup() {
      calc = null;
    }

    [TestMethod]
    public void EmptyStringTest() {
      Assert.AreEqual(0, calc.Add(null));
      Assert.AreEqual(0, calc.Add(String.Empty));
    }

    [TestMethod]
    public void SingleNumberTest() {
      Assert.AreEqual(1, calc.Add("1"));
      Assert.AreEqual(100, calc.Add("100"));
    }

    [TestMethod]
    public void TwoNumberTest() {
      Assert.AreEqual(3, calc.Add("1,2"));
    }

    [TestMethod]
    public void MultiNumberTest() {
      Assert.AreEqual(18, calc.Add("5,6,7"));
    }

    [TestMethod]
    public void MultipleSpearatorsTest() {
      Assert.AreEqual(6, calc.Add("1\n2,3"));
      Assert.AreEqual(1, calc.Add("1,\n"));
    }

    [TestMethod]
    public void PrecedingDelimiterTest() {
      Assert.AreEqual(3, calc.Add("//;\n1;2"));
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException), "Negatives not allowed")]
    public void NegativeNumberTest() {
      calc.Add("-1,-2");
    }

    [TestMethod]
    public void GreaterThan1000() {
      Assert.AreEqual(2, calc.Add("1001,2"));
    }

    [TestMethod]
    public void CustomDelimiter() {
      Assert.AreEqual(6, calc.Add("//[***]\n1***2***3"));
      Assert.AreEqual(6, calc.Add("//[*][%]\n1*2%3"));
      Assert.AreEqual(6, calc.Add("//[ABC]\n1DEF2GHI3"));
    }

  }
}
