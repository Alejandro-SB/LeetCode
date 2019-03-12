using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Array
{
    public static class SpiralMatrix
    {
        public static IList<int> Spiral(int[,] nums)
        {
            if (nums.GetLength(0) == 0)
            {
                return new List<int>();
            }

            var spiral = new List<int>();
            var direction = Direction.Right;
            int currentRow = 0;
            int currentColumn = 0;
            int minRow = 0;
            int maxRow = nums.GetLength(0) - 1;
            int minColumn = 0;
            int maxColumn = nums.GetLength(1) - 1;


            while (spiral.Count != nums.Length)
            {
                spiral.Add(nums[currentRow, currentColumn]);

                var next = MoveNext(currentRow, currentColumn, direction);

                if (next.Item1 < minRow || next.Item1 > maxRow)
                {
                    if (direction == Direction.Up)
                    {
                        direction = Direction.Right;
                        minColumn++;
                    }
                    else
                    {
                        direction = Direction.Left;
                        maxColumn--;
                    }

                    next = MoveNext(currentRow, currentColumn, direction);
                }
                else if(next.Item2 < minColumn || next.Item2 > maxColumn)
                {
                    if(direction == Direction.Right)
                    {
                        direction = Direction.Down;
                        minRow++;
                    }
                    else
                    {
                        direction = Direction.Up;
                        maxRow--;
                    }

                    next = MoveNext(currentRow, currentColumn, direction);
                }

                currentRow = next.Item1;
                currentColumn = next.Item2;
            }

            return spiral;
        }

        private static Tuple<int, int> MoveNext(int row, int col, Direction d)
        {
            switch (d)
            {
                case Direction.Up:
                    row--;
                    break;
                case Direction.Down:
                    row++;
                    break;
                case Direction.Left:
                    col--;
                    break;
                case Direction.Right:
                    col++;
                    break;
            }

            return new Tuple<int, int>(row, col);
        }

        public enum Direction
        {
            Up,
            Down,
            Left,
            Right
        }
    }
}
