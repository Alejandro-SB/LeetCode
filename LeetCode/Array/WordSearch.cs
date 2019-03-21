using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Array
{
    public static class WordSearch
    {
        public static bool Exist(char[,] board, string word)
        {
            if (word.Length == 0 || board.GetLength(0) == 0 || board.GetLength(1) == 0)
            {
                return true;
            }

            int rows = board.GetLength(0);
            int columns = board.GetLength(1);

            bool[,] visited = new bool[rows, columns];

            for (int i = 0; i < board.GetLength(0); ++i)
            {
                for (int j = 0; j < board.GetLength(1); ++j)
                {
                    if (board[i, j] == word[0])
                        if (ExistHelper(board, i, j, word, 0, visited))
                            return true;
                }
            }

            return false;
        }

        private static bool ExistHelper(char[,] board, int i, int j, string word, int index, bool[,] visited)
        {
            int rows = board.GetLength(0);
            int columns = board.GetLength(1);

            bool isOutOfBounds(int x, int y) => x < 0 || x >= rows || y < 0 || y >= columns;

            if (index == word.Length) return true;

            if (isOutOfBounds(i, j) || word[index] != board[i,j] || visited[i,j]) return false;

            visited[i, j] = true;

            if (ExistHelper(board, i + 1, j, word, index + 1, visited)) return true;
            if (ExistHelper(board, i - 1, j, word, index + 1, visited)) return true;
            if (ExistHelper(board, i, j + 1, word, index + 1, visited)) return true;
            if (ExistHelper(board, i, j - 1, word, index + 1, visited)) return true;

            visited[i, j] = false;

            return false;
        }

        //public static bool Exist(char[,] board, string word)
        //{
        //    var row = board.GetLength(0);
        //    var column = board.GetLength(1);
        //    var visited = new bool[row, column];

        //    if (word.Length == 0)
        //        return true;

        //    for (int i = 0; i < row; i++)
        //    {
        //        for (int j = 0; j < column; j++)
        //        {
        //            if (board[i, j] == word[0])
        //            {
        //                if (ExistHelper(board, i, j, word, 0, visited)) return true;
        //            }
        //        }
        //    }

        //    return false;
        //}

        //private static bool ExistHelper(char[,] board, int i, int j, string word, int index, bool[,] visited)
        //{
        //    if (i < 0 || i >= board.GetLength(0) || j < 0 || j >= board.GetLength(1)
        //       || board[i, j] != word[index] || visited[i, j]) return false;
        //    if (index == word.Length - 1) return true;

        //    visited[i, j] = true;

        //    if (ExistHelper(board, i - 1, j, word, index + 1, visited)) return true;
        //    if (ExistHelper(board, i + 1, j, word, index + 1, visited)) return true;
        //    if (ExistHelper(board, i, j - 1, word, index + 1, visited)) return true;
        //    if (ExistHelper(board, i, j + 1, word, index + 1, visited)) return true;

        //    visited[i, j] = false;

        //    return false;
        //}
    }
}