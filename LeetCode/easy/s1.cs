using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.easy
{
    internal class TwoNums
    {
        public static int[] Soltion(int[] nums, int target)
        {
            var dic = new Dictionary<int, int>();
            for (var i = 0; i < nums.Length; i++)
            {
                if (dic.ContainsKey(target - nums[i]))
                {
                    return new int[] { i, dic[target - nums[i]] };
                }
                else if(!dic.ContainsKey(nums[i]))
                {
                    dic.Add(nums[i], i);
                }
            }
            return null;
        }
    }
}
