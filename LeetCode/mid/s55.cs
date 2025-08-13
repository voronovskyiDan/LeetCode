using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.mid
{
    class JumpGame
    {
        public static bool Solution(int[] nums)
        {
            int max = 0;

            for(int i = 0; i < nums.Length; i++)
            {
                if (i > max)
                    return false;

                if (max < nums[i] + i)
                {
                    max = nums[i] + i;
                }
            }

            return true;
        }
    }
}
