namespace LeetCode.Parentheses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Parentheses
    {
        public static bool IsValid(string s)
        {
            if(string.IsNullOrEmpty(s))
            {
                return true;
            }

            var previousChars = new Stack<char>();
            
            foreach(var c in s)
            {
                if(IsClosingTag(c))
                {
                    if(previousChars.Count>0)
                    {
                        char prev = previousChars.Pop();
                        if(prev != GetMatch(c))
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    previousChars.Push(c);
                }
            }

            return previousChars.Count == 0;
        }

        public static bool IsClosingTag(char c)
        {
            char[] closers = new char[] { ']', '}', ')' };

            return closers.Any(ch => ch == c);
        }

        public static char GetMatch(char c)
        {
            char result;

            switch (c)
            {
                case ']':
                    result = '[';
                    break;
                case ')':
                    result = '(';
                    break;
                case '}':
                    result = '{';
                    break;
                default:
                    throw new ArgumentException();
            }

            return result;
        }
    }
}
