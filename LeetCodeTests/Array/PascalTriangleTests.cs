using System.Linq;
using System;
using System.Collections.Generic;
using LeetCode.Array;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests.Array
{
    [TestClass]
    public class PascalTriangleTests
    {
        [TestMethod]
        public void TriangleTest()
        {
            var triangle = PascalTriangle.Triangle(5);

            var result = new List<List<int>>()
            {
                new List<int>()
                {
                    1
                },
                new List<int>()
                {
                    1,1
                },
                new List<int>()
                {
                    1,2,1
                },
                new List<int>()
                {
                    1,3,3,1
                },
                new List<int>()
                {
                    1,4,6,4,1
                }
            };

            if (result.Count != triangle.Count)
            {
                Assert.Fail();
            }

            for (int i = 0; i < result.Count; i++)
            {
                CollectionAssert.AreEqual(result[i], triangle[i].ToList());
            }
        }

        [TestMethod]
        public void EmptyCollectionTest()
        {
            var triangle = PascalTriangle.Triangle(0);


            CollectionAssert.AreEqual(new List<IList<int>>(), triangle.ToList());
        }

        [TestMethod]
        public void BiggerNumberTest()
        {
            var expected = new List<List<int>>()
            {
                new List<int>(){1},
                new List<int>(){1, 1},
                new List<int>(){1, 2, 1},
                new List<int>(){1, 3, 3, 1},
                new List<int>(){1, 4, 6, 4, 1},
                new List<int>(){1, 5, 10, 10, 5, 1},
                new List<int>(){1, 6, 15, 20, 15, 6, 1},
                new List<int>(){1, 7, 21, 35, 35, 21, 7, 1},
                new List<int>(){1, 8, 28, 56, 70, 56, 28, 8, 1},
                new List<int>(){1, 9, 36, 84, 126, 126, 84, 36, 9, 1},
                new List<int>(){1, 10, 45, 120, 210, 252, 210, 120, 45, 10, 1},
                new List<int>(){1, 11, 55, 165, 330, 462, 462, 330, 165, 55, 11, 1},
                new List<int>(){1, 12, 66, 220, 495, 792, 924, 792, 495, 220, 66, 12, 1},
                new List<int>(){1, 13, 78, 286, 715, 1287, 1716, 1716, 1287, 715, 286, 78, 13, 1},
                new List<int>(){1, 14, 91, 364, 1001, 2002, 3003, 3432, 3003, 2002, 1001, 364, 91, 14, 1},
            };

            var triangle = PascalTriangle.Triangle(15);

            for (int i = 0; i < expected.Count; i++)
            {
                CollectionAssert.AreEqual(expected[i], triangle[i].ToList());
            }
        }
    }
}
