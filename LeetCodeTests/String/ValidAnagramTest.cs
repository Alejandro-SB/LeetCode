using System;
using LeetCode.String;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests.String
{
    [TestClass]
    public class ValidAnagramTest
    {
        [TestMethod]
        public void ValidAnagramSimpleTest()
        {
            string s = "anagram", 
                t = "nagaram";

            Assert.AreEqual(true, StringProgram.IsAnagram(s,t));
        }
    }
}
