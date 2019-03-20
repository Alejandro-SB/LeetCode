using System;
using LeetCode.Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

/// <summary>
/// https://leetcode.com/problems/basic-calculator-ii/
/// </summary>
namespace LeetCodeTests.Calculator
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void CalculatesSimpleSumTest()
        {
            var simpleSum = "3+2";

            var result = Calculator2.Calculate(simpleSum);

            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void AppliesOperatorPrecedenceTest()
        {
            var input = "3+2*3";

            var result = Calculator2.Calculate(input);

            Assert.AreEqual(9, result);
        }

        [TestMethod]
        public void CalculatesComplexOperationTest()
        {
            var input = "   3  - 98 * 44 /15-3  ";

            var result = Calculator2.Calculate(input);

            Assert.AreEqual(-287, result);
        }

        [TestMethod]
        public void ManagesZeroTest()
        {
            var input = "0*1";

            var result = Calculator2.Calculate(input);

            Assert.AreEqual(0, result);
        }
    }
}