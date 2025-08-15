using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.easy
{
    class IsSubsequence
    {
        public static bool Solution(string s, string t)
        {
            int i = 0, j = 0;

            while(j < t.Length && i < s.Length)
            {
                if (s[i] == t[j])
                    i++;
                j++;
            }


            return i == s.Length;
        }
    }
}
