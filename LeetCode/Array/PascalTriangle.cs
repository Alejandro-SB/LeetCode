using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Array
{
    public static class PascalTriangle
    {
        public static IList<IList<int>> Triangle(int rows)
        {
            var triangle = new List<IList<int>>();

            for (int row = 0; row < rows; ++row)
            {
                var level = new List<int>();

                int maxColumn = row + 1;

                for (int column = 0; column < maxColumn; ++column)
                {
                    if(column == 0 || column == row)
                    {
                        level.Add(1);
                    }
                    else
                    {
                        int topLeft = triangle[row - 1][column - 1];
                        int topRight = triangle[row - 1][column];

                        level.Add(topLeft + topRight);
                    }
                }

                triangle.Add(level);
            }


            return triangle;
        }
    }
}
