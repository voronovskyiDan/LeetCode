using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.mid
{
    internal class RangeBitwiseAnd
    {
        public static int Solution(int left, int right)
        {
            while (right > left)
            {
                right &= right - 1;
            }

            return right;
        }
    }
}
