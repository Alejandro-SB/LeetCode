using System;
using LeetCode.String;
using Microsoft.VisualStudio.TestTools.UnitTesting;


/// <summary>
/// https://leetcode.com/problems/first-unique-character-in-a-string/
/// </summary>
namespace LeetCodeTests.FirstUniqueCharacter
{
    [TestClass]
    public class FirstUniqueTest
    {
        [TestMethod]
        public void Returns_Index_Test()
        {
            Assert.AreEqual(-1, FirstUniqueChar.FirstUniqeChar(string.Empty));
            Assert.AreEqual(-1, FirstUniqueChar.FirstUniqeChar("poop"));

            Assert.AreEqual(3, FirstUniqueChar.FirstUniqeChar("asdfdsa"));
            Assert.AreEqual(2, FirstUniqueChar.FirstUniqeChar("loveleetcode"));
        }
    }
}
