using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCode.easy
{
    class SummaryRanges
    {
        public static IList<string> Solution(int[] nums)
        {
            List<string> res = new();

            if (nums.Length == 0) return res;


            int l = 0, r = 0;

            while(r < nums.Length-1)
            {
                if(nums[r] + 1 != nums[r+1])
                {
                    res.Add(l != r ? nums[l] + "->" + nums[r] : nums[l].ToString());
                    r += 1;
                    l = r;
                    continue;
                }
                r++;                 
            }
            res.Add(l != r ? nums[l] + "->" + nums[r] : nums[l].ToString());

            return res;
        }
    }
}
