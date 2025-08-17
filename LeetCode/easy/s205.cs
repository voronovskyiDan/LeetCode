using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.easy
{
    class IsomorphicStrings
    {
        public static bool Solution(string s, string t)
        {
            char[] sDict = new char[256];
            char[] tDict = new char[256];
            for (var i = 0; i < s.Length; i++)
            {
                char schar = s[i];
                char tchar = t[i];

                if (sDict[schar] != '\0' &&  sDict[schar] != tchar)
                        return false;
                if (tDict[tchar] != '\0' && tDict[tchar] != schar)
                        return false;
                
                sDict[schar] = tchar;
                tDict[tchar] = schar;
            }
            return true;
        }
    }
}
