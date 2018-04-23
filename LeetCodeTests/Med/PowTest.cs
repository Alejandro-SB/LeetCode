namespace LeetCodeTests.Med
{
    using System;
    using LeetCode.Med;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class PowTest
    {
        [TestMethod]
        [DataRow(2,5)]
        [DataRow(1, 3)]
        [DataRow(3,13)]
        [DataRow(15, 2)]
        [DataRow(13.5, 7)]
        [DataRow(2, -2)]
        [DataRow(-50, 5)]
        [DataRow(0.00001, 2147483647)]
        public void ShouldReturnCorrectValue(double x, int n)
        {
            Assert.AreEqual(Math.Pow(x, (double)n), Pow.MyPow(x, n));
        }
    }
}
