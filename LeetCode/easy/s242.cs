using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.easy
{
    class ValidAnagram
    {
        public static bool Solution(string s, string t)
        {
            Dictionary<char, int> map = new();

            if (s.Length != t.Length)
                return false;

            for(int i = 0; i < s.Length; i++)
            {
                if (!map.ContainsKey(s[i]))
                    map.Add(s[i], 1);
                else
                    map[s[i]]++;
            }

            for(int i = 0; i < t.Length; i++)
            {
                if (!map.ContainsKey(t[i]))
                    return false;
                
                int c = --map[t[i]];
                if (c < 0)
                    return false;
            }
            return true;
        }
    }
}
