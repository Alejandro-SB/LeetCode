using System;
using System.Collections.Generic;

namespace LeetCode.Array
{
    public static class DiagonalTraverse
    {
        public static int[] Traverse(int[,] matrix)
        {
            if(matrix.GetLength(0) == 0)
            {
                return new int[] { };
            }

            var direction = Direction.Up;
            var rowNumber = matrix.GetLength(0);
            var columnNumber = matrix.GetLength(1);
            int currentRow = 0;
            int currentColumn = 0;

            var nums = new List<int>() { matrix[0, 0] };

            bool isOoB(int r, int c) => r < 0 || r >= rowNumber || c < 0 || c >= columnNumber;

            while (currentColumn <= columnNumber && currentRow <= rowNumber)
            {
                if (direction == Direction.Up)
                {
                    currentRow--;
                    currentColumn++;
                }
                else
                {
                    currentRow++;
                    currentColumn--;
                }

                if (isOoB(currentRow, currentColumn))
                {
                    if(direction == Direction.Up)
                    {
                        if (isOoB(currentRow + 1, currentColumn))
                        {
                            currentRow++;
                        }
                        else
                        {
                            currentColumn++;
                        }

                        direction = Direction.Down;
                    }
                    else
                    {
                        if(isOoB(currentRow, currentColumn+1))
                        {
                            currentColumn++;
                        }
                        else
                        {
                            currentRow++;
                        }

                        direction = Direction.Up;
                    }
                }
                else
                {
                    nums.Add(matrix[currentRow, currentColumn]);
                }
            }

            return nums.ToArray();
        }
    }

    public enum Direction
    {
        Up,
        Down
    }
}