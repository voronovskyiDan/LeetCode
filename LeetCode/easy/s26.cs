using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.easy
{
    class RemoveDublicatesFromSortedArray
    {
        public static int Solution(int[] nums)
        {
            int uniqPointer = 1, tmp = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != tmp)
                {
                    nums[uniqPointer] = nums[i];
                    tmp = nums[i];
                    uniqPointer++;
                }
            }

            return uniqPointer;
        }
    }
}
