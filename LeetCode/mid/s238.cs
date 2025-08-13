using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.mid
{
    class ProductOfArrayExceptSelf
    {
        public static int[] Solution(int[] nums)
        {
            int[] res = new int[nums.Length];
            for (int i = 0; i < res.Length; i++)
                res[i] = 1;

            int prSum = 1;

            for(int i = 0; i < nums.Length; i++)
            {
                res[i] *= prSum;
                prSum *= nums[i];
            }

            prSum = 1;

            for (int i = nums.Length-1; i >= 0; i--)
            {
                res[i] *= prSum;
                prSum *= nums[i];
            }

            return res;
        }
    }
}
