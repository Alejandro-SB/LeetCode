using System;
using LeetCode.String;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests.String
{
    [TestClass]
    public class ReverseIntegerTest
    {
        [TestMethod]
        public void ReverseNormalIntegerTest()
        {
            int x = 123;

            Assert.AreEqual(321, StringProgram.ReverseInteger(x));
        }

        [TestMethod]
        public void ReverseSignedIntegerTest()
        {
            int x = -123;

            Assert.AreEqual(-321, StringProgram.ReverseInteger(x));
        }

        [TestMethod]
        public void ReverseTrailingZeroIntegerTest()
        {
            int x = 320;

            Assert.AreEqual(23, StringProgram.ReverseInteger(x));
        }

        [TestMethod]
        public void ReverseBigNumberTest()
        {
            int x = 1534236469;

            Assert.AreEqual(0, StringProgram.ReverseInteger(x));
        }

        [TestMethod]
        public void ReverseTwoComplementIntegerTest()
        {
            int x = -2147483648;

            Assert.AreEqual(0, StringProgram.ReverseInteger(x));
        }
    }
}
