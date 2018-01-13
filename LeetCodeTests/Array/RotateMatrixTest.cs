using System;
using LeetCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests.Array
{
    [TestClass]
    public class RotateMatrixTest
    {
        [TestMethod]
        public void Rotate2x2MatrixTest()
        {
            int[,] matrix = new int[2, 2]
            {
                {1,2 },
                {3,4 }
            };

            ArrayProgram.RotateMatrix(matrix);

            CollectionAssert.AreEqual(new int[2, 2] { { 3, 1 }, { 4, 2 } }, matrix);
        }

        [TestMethod]
        public void Rotate3x3MatrixTest()
        {
            int[,] matrix = new int[3, 3]
            {
                {1,2,3 },
                {4,5,6 },
                {7,8,9 }
            };

            ArrayProgram.RotateMatrix(matrix);

            CollectionAssert.AreEqual(new int[3, 3] { { 7, 4, 1 }, { 8, 5, 2 }, { 9, 6, 3 } }, matrix);
        }

        [TestMethod]
        public void Rotate4x4MatrixTest()
        {
            int[,] matrix = new int[4, 4]
            {
                {5, 1, 9, 11},
                {2, 4, 8, 10},
                {13, 3, 6, 7},
                {15, 14, 12, 16}
            };

            int[,] result = new int[4, 4]
            {
                {15, 13, 2, 5},
                {14, 3, 4, 1},
                {12, 6, 8, 9},
                {16, 7, 10, 11}
            };

            ArrayProgram.RotateMatrix(matrix);

            CollectionAssert.AreEqual(result, matrix);
        }
    }
}
