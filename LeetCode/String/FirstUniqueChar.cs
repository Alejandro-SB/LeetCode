using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.String
{
    public static class FirstUniqueChar
    {
        public static int FirstUniqeChar(string s)
        {
            var frequencies = new Dictionary<char, int>();

            foreach (char c in s)
            {
                if (frequencies.TryGetValue(c, out int number))
                {
                    frequencies[c] = number + 1;
                }
                else
                {
                    frequencies.Add(c, 1);
                }
            }

            for (int i = 0; i < s.Length; ++i)
            {
                if(frequencies[s[i]] == 1)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
