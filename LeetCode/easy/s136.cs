using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.easy
{
    internal class SingleNumber
    {
        public static int Solution(int[] nums)
        {
            int result = 0;
            foreach (int num in nums)
            {
                result ^= num;
            }
            return result;
        }
    }
}
