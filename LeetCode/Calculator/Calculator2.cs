using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Calculator
{
    public static class Calculator2
    {
        public static int Calculate(string input)
        {
            char previousSign = '+';
            const string numbers = "0123456789";
            const string signs = "/*-+";

            int currentNum = 0;

            Stack<int> ops = new Stack<int>();

            for (int i = 0; i < input.Length; ++i)
            {
                char c = input[i];

                if (numbers.Contains(c))
                {
                    currentNum = currentNum * 10 + int.Parse(c.ToString());
                }

                if((signs.Contains(c) && c != ' ') || i == input.Length -1)
                {
                    if(previousSign == '-')
                    {
                        ops.Push(-currentNum);
                    }
                    else if(previousSign == '+')
                    {
                        ops.Push(currentNum);
                    }
                    else
                    {
                        if(previousSign == '*')
                        {
                            currentNum = ops.Pop() * currentNum;
                        }
                        else
                        {
                            currentNum = ops.Pop() / currentNum;
                        }

                        ops.Push(currentNum);
                    }

                    previousSign = c;
                    currentNum = 0;
                }
            }

            int result = 0;

            while (ops.Any())
            {
                result += ops.Pop();
            }

            return result;
        }
    }
}