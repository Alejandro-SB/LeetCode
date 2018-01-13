using System;
using LeetCode.String;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests.String
{
    [TestClass]
    public class FirstUniqCharTest
    {
        [TestMethod]
        public void FirstUniqueCharTest()
        {
            string s = "testing";

            Assert.AreEqual(1, StringProgram.FirstUniqChar(s));
        }

        [TestMethod]
        public void FirstUniqueCharInComplexStringTest()
        {
            string s = "testing a really complex string";

            Assert.AreEqual(15, StringProgram.FirstUniqChar(s));
        }
    }
}
