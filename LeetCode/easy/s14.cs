using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.easy
{
    class LongestCommonPrefix
    {
        public static string Solution(string[] strs)
        {
            if (strs.Length == 0)
                return "";

            string res = strs[0];
            int resLen = res.Length;

            for(int i = 1; i < strs.Length; i++)
            {
                string s = strs[i];

                while(resLen > s.Length || res != s.Substring(0, resLen))
                {
                    resLen--;
                    if (resLen == 0)
                        return "";

                    res = res.Substring(0, resLen);
                }
            }
            
            return res;
        }
    }
}
