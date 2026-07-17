using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.easy
{
    internal class NumberOf1Bits
    {
        public static int Solution(int n) {
            int count = 0;
            while (n != 0)
            {
                if ((n & 1) == 1)
                    count++;
                n = n >>> 1;
            }
            return count;
        }
    }
}
