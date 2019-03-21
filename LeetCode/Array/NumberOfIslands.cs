using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Array
{
    public static class NumberOfIslands
    {
        private static int Counter = 0;
        private static bool[,] Visited;

        public static int NumIslands(char[,] grid)
        {
            int rows = grid.GetLength(0);
            int columns = grid.GetLength(1);

            Visited = new bool[rows, columns];

            for(int i = 0;i<rows;++i)
            {
                for(int j=0;j<columns;++j)
                {
                    if(grid[i,j] == '1' && !Visited[i,j])
                    {
                        Counter++;
                        IslandHelper(grid, i, j);
                    }
                }
            }

            return Counter;
        }

        private static void IslandHelper(char[,] grid, int i, int j)
        {
            int rows = grid.GetLength(0);
            int cols = grid.GetLength(1);

            if (i < 0 || i >= rows || j < 0 || j >= cols) return;
            if (grid[i, j] == '0') return;
            if (Visited[i, j]) return;

            Visited[i, j] = true;

            IslandHelper(grid, i + 1, j);
            IslandHelper(grid, i, j + 1);
            IslandHelper(grid, i - 1, j);
            IslandHelper(grid, i, j - 1);
        }
    }
}
