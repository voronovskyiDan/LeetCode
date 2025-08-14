using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.easy
{
    class FindTheFirstOccuranceInString
    {
        public static int Solution(string haystack, string needle)
        {
            if (needle.Length > haystack.Length)
                return -1;

            bool isFound = false;
            int res = 0;

            while (res != haystack.Length)
            {
                if (haystack[res] == needle[0])
                {
                    if (haystack.Length - res < needle.Length)
                        return -1;

                    isFound = true;
                    for (int j = 0; j < needle.Length; j++)
                    {
                        if (haystack[res + j] != needle[j])
                        {
                            isFound = false;
                            res++;
                            break;
                        }
                    }

                    if (isFound)
                        return res;
                }
                else
                {
                    res++;
                }
            }
            return -1;
        }
    }
}
