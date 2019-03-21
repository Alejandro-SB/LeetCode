using System;
using LeetCode.Array;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests.Array
{
    [TestClass]
    public class WordSearchTest
    {
        [TestMethod]
        public void FindsWordInMatrixTest()
        {
            var board = new char[,]
            {
                {'A', 'B', 'C', 'E'},
                {'S', 'F', 'C', 'S'},
                {'A', 'D', 'E', 'E'}
            };

            Assert.IsTrue(WordSearch.Exist(board, string.Empty));
            Assert.IsTrue(WordSearch.Exist(board, "A"));
            Assert.IsTrue(WordSearch.Exist(board, "C"));
            Assert.IsTrue(WordSearch.Exist(board, "SEE"));
            Assert.IsTrue(WordSearch.Exist(board, "ABCCED"));
            Assert.IsFalse(WordSearch.Exist(board, "ABCB"));
        }

        [TestMethod]
        public void ComplexTest()
        {
            var board = new char[,]
            {
                { 'A', 'B', 'C', 'E' },
                { 'S', 'F', 'E', 'S' },
                { 'A', 'D', 'E', 'E' }
            };

            Assert.IsTrue(WordSearch.Exist(board, "ABCEFSADEESE"));

        }
    }
}