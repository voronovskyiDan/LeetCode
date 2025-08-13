using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.mid
{
    class JumpGameTwo
    {
        public static int Solution(int[] nums)
        {
            int end = nums.Length - 1;
            if (end == 0)
                return 0;

            int jumps = 0;
            int current_jump = 0;
            int max = 0;

            for(int i = 0; i < end; i++)
            {
                if(max < i + nums[i])
                {
                    max = i + nums[i];
                }

                if(i == current_jump)
                {
                    jumps++;
                    current_jump = max;
                }
            }
            return jumps;
        }
    }
}
