using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.String
{
    public class StringProgram
    {
        public static string Reverse(string s)
        {
            char[] word = s.ToCharArray();
            Array.Reverse(word);
            return string.Join("", word);
        }

        public static bool IsAnagram(string s, string t)
        {
            var groupS = s.GroupBy(c => c).Select(c => new { key = c.Key, count = c.Count() });
            var groupT = t.GroupBy(c => c).Select(c => new { key = c.Key, count = c.Count() });

            foreach(var e in groupS)
            {
                if (e.count != groupT.Where(c => c.key == e.key).FirstOrDefault().count)
                    return false;
            }

            if (s.Length != t.Length)
                return false;

            return true;
        }

        public static int ReverseInteger(int x)
        {
            if (x == int.MinValue)
                return 0;

            if (x < 0)
                return -ReverseInteger(Math.Abs(x));
            else
            {
                char[] s = x.ToString().ToCharArray();
                Array.Reverse(s);
                if (int.TryParse(string.Join("", s), out int number))
                    return number;
                else
                    return 0;
            }
        }

        public static int FirstUniqChar(string s)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();
            Dictionary<char, int> dicIndex = new Dictionary<char, int>();
            char c;

            for(int i = 0;i<s.Length;i++)
            {
                c = s[i];
                if (dic.ContainsKey(c))
                    dic[c]++;
                else
                {
                    dic.Add(c, 1);
                    dicIndex.Add(c, i);
                }
            }

            for(int i=0;i<s.Length;i++)
            {
                c = s[i];
                if (dic[c] == 1)
                    return dicIndex[c];
            }

            return -1;
        }
    }
}
