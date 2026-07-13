using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.easy
{
    internal class ReverseBits
    {
        public static int Solution(int n)
        {
            uint x = unchecked((uint)n);
            uint result = 0;

            for (int i = 0; i < 32; i++)
            {
                result <<= 1;
                result |= x & 1;
                x >>= 1;
            }

            return unchecked((int)result);
        }
    }
}
