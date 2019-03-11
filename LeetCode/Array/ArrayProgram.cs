using LeetCode.Array;
using LeetCode.String;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ArrayProgram
    {
        public int DominantIndex(int[] nums)
        {
            int max = -1;
            int maxIndex = -1;

            //Get max
            for (int i = 0; i < nums.Length; ++i)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                    maxIndex = i;
                }
            }

            for (int i = 0; i < nums.Length; ++i)
            {
                if (i != maxIndex && nums[i] != 0 && nums[maxIndex] / nums[i] < 2)
                {
                    return -1;
                }
            }

            return maxIndex;
        }

        public static int[] CountBits(int num)
        {
            int[] ints = new int[num + 1];
            int testNumber = 0,
                numTwos;

            for (int i = 0; i <= num; i++)
            {
                testNumber = i;
                numTwos = 0;

                while (testNumber != 0)
                {
                    if (testNumber % 2 == 0)
                    {
                        testNumber /= 2;
                    }
                    else
                    {
                        numTwos++;
                        testNumber--;
                    }
                }

                ints[i] = numTwos;
            }

            return ints;
        }


        #region Solutions

        public static void RotateMatrix(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            int temp;

            for (int i = 0; i < n / 2; i++)
            {
                for (int j = 0; j < Math.Ceiling(n / 2.0); j++)
                {
                    temp = matrix[i, j];
                    matrix[i, j] = matrix[n - 1 - j, i];
                    matrix[n - 1 - j, i] = matrix[n - 1 - i, n - 1 - j];
                    matrix[n - 1 - i, n - 1 - j] = matrix[j, n - 1 - i];
                    matrix[j, n - 1 - i] = temp;
                }
            }

            ////Optimal
            //var x = 0;
            //var y = matrix.GetLength(0) - 1;

            //while (x < y)
            //{
            //    for (int i = 0; i < y - x; i++)
            //    {
            //        var temp = matrix[x, x + i];
            //        matrix[x, x + i] = matrix[y - i, x];
            //        matrix[y - i, x] = matrix[y, y - i];
            //        matrix[y, y - i] = matrix[x + i, y];
            //        matrix[x + i, y] = temp;
            //    }

            //    x++;
            //    y--;
            //}
        }

        public static bool ValidateSudoku(char[,] sudoku)
        {
            Hashtable dicRow, dicColumn, dicBlock;

            char elementRow, elementColumn, elementBlock;
            //Validate Rows
            for (int i = 0; i < sudoku.GetLength(0); i++)
            {
                dicRow = new Hashtable();
                dicColumn = new Hashtable();

                for (int j = 0; j < sudoku.GetLength(1); j++)
                {
                    elementRow = sudoku[i, j];
                    elementColumn = sudoku[j, i];

                    if (elementRow != '.')
                    {
                        if (dicRow.ContainsKey(elementRow))
                            return false;
                        else
                            dicRow.Add(elementRow, elementRow);

                    }

                    if (elementColumn != '.')
                    {
                        if (dicColumn.ContainsKey(elementColumn))
                            return false;
                        else
                            dicColumn.Add(elementColumn, elementColumn);

                    }
                }
            }

            //Small Squares
            for (int block = 0; block < 9; block++)
            {
                dicBlock = new Hashtable();
                for (int i = block / 3 * 3; i < block / 3 * 3 + 3; i++)
                {
                    for (int j = block % 3 * 3; j < block % 3 * 3 + 3; j++)
                    {
                        elementBlock = sudoku[i, j];
                        if (elementBlock != '.')
                        {
                            if (dicBlock.ContainsKey(elementBlock))
                                return false;
                            else
                                dicBlock.Add(elementBlock, elementBlock);
                        }
                    }
                }
            }

            return true;
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> complements = new Dictionary<int, int>();
            int complementary;

            for (int i = 0; i < nums.Length; i++)
            {
                complementary = target - nums[i];

                if (complements.ContainsKey(nums[i]))
                    return new int[] { complements[nums[i]], i };
                else if (!complements.ContainsKey(complementary))
                    complements.Add(complementary, i);
            }

            return new int[] { };
        }

        public static void MoveZeroes(int[] nums)
        {
            ////SOLUTION 1: Concat != 0 and 0 using LINQ
            //// Works when passing by ref
            //int[] zeroes = nums.Where(x => x == 0).ToArray();
            //int[] numbers = nums.Where(x => x != 0).ToArray();

            //nums = numbers.Concat(zeroes).ToArray();

            //SOLUTION 2: In-place modification
            int index2 = 0;
            int index = 0;

            while (index2 < nums.Length)
            {
                if (nums[index2] == 0)
                {
                    index2++;
                }
                else
                {
                    nums[index] = nums[index2];
                    index2++;
                    index++;
                }
            }

            for (int i = index; i < nums.Length; i++)
            {
                nums[i] = 0;
            }
        }

        public static int[] PlusOne(int[] num)
        {
            num[num.Length - 1]++;
            List<int> parsedNum = new List<int>();
            int index = num.Length - 1;
            int acc = 0;
            int number;

            while (index >= 0)
            {
                number = num[index] + acc;
                parsedNum.Insert(0, number % 10);
                acc = (int)Math.Floor((double)number / 10);
                index--;
            }

            if (acc != 0)
                parsedNum.Insert(0, acc);

            return parsedNum.ToArray();
        }

        public static int FindSingle(int[] nums)
        {
            return nums.GroupBy(x => x).Where(x => x.Count() == 1).Single().Key;
        }

        public static int[] Intersection(int[] nums1, int[] nums2)
        {
            //Array.Sort(nums1);
            //Array.Sort(nums2);

            List<int> temp = new List<int>();
            int i = 0;
            int j = 0;

            while (i < nums1.Length && j < nums2.Length)
            {
                if (nums1[i] == nums2[j])
                {
                    temp.Add(nums1[i]);
                    i++;
                    j++;
                }
                else if (nums1[i] < nums2[j])
                {
                    i++;
                }
                else
                {
                    j++;
                }
            }

            return temp.ToArray();
        }

        public static bool HasDuplicates(int[] nums)
        {
            return nums.GroupBy(x => x).Where(x => x.Count() > 1).Count() > 0;
        }

        public static void RotateArray(ref int[] nums, int k)
        {
            if (nums == null)
                return;

            if (k <= 0 || nums.Length == 0 || k >= nums.Length)
                return;

            var segment1 = new ArraySegment<int>(nums, 0, k);
            var segment2 = new ArraySegment<int>(nums, k, nums.Length - k);


            nums = segment2.Concat(segment1).ToArray();
        }

        #endregion
    }
}
