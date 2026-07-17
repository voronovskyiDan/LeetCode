using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.mid
{
    internal class SingleNumnberII
    {
        public static int Solution(int[] nums)
        {
            int ones = 0, twos = 0;
            foreach (int num in nums)
            {
                twos |= ones & num;
                ones ^= num;
                int threes = ones & twos;
                ones &= ~threes;
                twos &= ~threes;
            }
            return ones;
        }
    }
}
