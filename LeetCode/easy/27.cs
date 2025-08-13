using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.easy
{
    class RemoveElement
    {
        public static int Solution(int[] nums, int val)
        {
            int lp = 0, rp = nums.Length-1;

            while (lp <= rp)
            {
                if(nums[rp] == val)
                {
                    rp--;
                    continue;
                }

                if (nums[lp] == val)
                {
                    int tmp = nums[rp];
                    nums[rp] = nums[lp];
                    nums[lp] = tmp;
                    rp--;
                }
                lp++;
            }

            return lp;
        }
    }
}
