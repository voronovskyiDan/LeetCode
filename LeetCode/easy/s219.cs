using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.easy
{
    class ContainsDublicatesTwo
    {
        public static bool Solution(int[] nums, int k)
        {
            Dictionary<Int32, Int32> checkedValues = new();

            for (int i = 0; i < nums.Length; i++)
            {
                if (checkedValues.ContainsKey(nums[i]) && i - checkedValues[nums[i]] <= k)
                {
                    return true;
                }

                checkedValues[nums[i]] = i;
            }
            return false;
        }
    }
}
