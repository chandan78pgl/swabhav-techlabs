using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorLib.Swabhav;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculatorLib.Tests
{
    [TestClass]
    public class CalcTest
    {
        [TestMethod]
        public void TestCalculatorMethod()
        {
            Calculator calculator = new Calculator();

            Assert.AreEqual(64, calculator.CubeEvenNumber(4));
        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestCalculatorMethodOdd()
        {
            Calculator calculator = new Calculator();

            calculator.CubeEvenNumber(3);
        }
    }
}
