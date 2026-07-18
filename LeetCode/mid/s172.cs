using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.mid
{
    internal class FactorialTrailingZeroes
    {
        public static int Solution(int n)
        {
            int count = 0;
            while (n > 0)
            {
                n /= 5;
                count += n;
            }
            return count;
        }
    }
}
