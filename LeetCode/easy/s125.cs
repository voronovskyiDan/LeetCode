using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.easy
{
    class ValidPalindrome
    {
        public static bool Solution(string s)
        {
            int l = 0, r = s.Length - 1;
            bool isLeftLetter = false, isRightLetter = false;


            while (l < r)
            {
                isLeftLetter = Char.IsLetterOrDigit(s[l]);
                isRightLetter = Char.IsLetterOrDigit(s[r]);


                if(isLeftLetter && isRightLetter)
                {
                    if (Char.ToLower(s[l]) != Char.ToLower(s[r]))
                        return false;
                    l++;
                    r--;
                }

                if (!isLeftLetter)
                    l++;
                if (!isRightLetter)
                    r--;
            }

            return true;
        }
    }
}
