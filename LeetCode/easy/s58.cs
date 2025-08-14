using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.easy
{
    class LengthOfLastWord
    {
        public static int Solution(string s)
        {
            int begin = -1, end = -1;

            for(int i = s.Length-1; i >= 0; i--)
            {
                if (end == -1 && s[i] != ' ')
                {
                    end = i;
                }
                else if(end != -1 && s[i] == ' ' )
                {
                    begin = i + 1;
                    break;
                }
            }

            if (begin == -1 && end != -1)
                begin = 0;

            return end - begin + 1;
        }
    }
}
