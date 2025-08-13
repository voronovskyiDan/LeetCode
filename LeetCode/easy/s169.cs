using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.easy
{
    class MajorityElement
    {
        public static int Solution(int[] nums)
        {
            int majority = 0, count = 0;

            foreach(int it in nums)
            {
                if (count == 0)
                    majority = it;

                count += it == majority ? 1 : -1;
            }

            return majority;
        }
    }
}
