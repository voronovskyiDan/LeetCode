using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.mid
{
    class LongestSubstring
    {
        public static int Solution(string s)
        {
            int maxLenght = 0;
            int l = 0, r = 0;

            if (s.Length == 0 || s.Length == 1)
                return s.Length;

            HashSet<char> visited = new HashSet<char>();

            while(r < s.Length)
            {
                char ch = s[r];

                while (visited.Contains(ch))
                {
                    visited.Remove(s[l]);
                    l++;
                }

                visited.Add(ch);
                r++;

                if (r - l > maxLenght)
                {
                    maxLenght = r - l;
                }

            }

            return maxLenght;
        }
    }
}