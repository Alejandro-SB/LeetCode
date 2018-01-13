using System;
using LeetCode.String;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests.String
{
    [TestClass]
    public class ReverseTest
    {
        [TestMethod]
        public void ReverseEmptyStringTest()
        {
            Assert.AreEqual(string.Empty, StringProgram.Reverse(string.Empty));
        }

        [TestMethod]
        public void ReverseSimpleStringTest()
        {
            string s = "Hello!";

            Assert.AreEqual("!olleH", StringProgram.Reverse(s));
        }

        [TestMethod]
        public void ReverseComplexStringTest()
        {
            string s = "This is a complex string!";

            Assert.AreEqual("!gnirts xelpmoc a si sihT", StringProgram.Reverse(s));
        }
    }
}
