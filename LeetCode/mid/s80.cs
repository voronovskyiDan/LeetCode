using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.mid
{
    class RemoveDublicatesFromSortedArrayMid
    {
        public static int Solution(int[] nums)
        {
            int uniqPointer = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if (uniqPointer == 0 || uniqPointer == 1 || nums[i] != nums[uniqPointer - 2])
                {
                    nums[uniqPointer] = nums[i];
                    uniqPointer++;
                }
            }

            return uniqPointer;
        }
    }
}
