using System;
using LeetCode.Array;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests.Array
{
    [TestClass]
    public class NumberOfIslandsTests
    {
        [TestMethod]
        public void CountIslandsTest()
        {
            var grid = new char[,]
            {
                { '1', '1', '0', '0', '0' },
                { '1', '1', '0', '0', '0' },
                { '0', '0', '1', '0', '0' },
                { '0', '0', '0', '1', '1' }
            };

            Assert.AreEqual(3, NumberOfIslands.NumIslands(grid));
        }
    }
}
