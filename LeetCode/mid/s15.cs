using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.mid
{
    class ThreeSum
    {
        public static IList<IList<int>> Solution(int[] nums)
        {
            List<IList<int>> res = new();

            Array.Sort(nums); // O(n*log(n))

            int l, r;
            int sum = 0;
            for(int i = 0; i < nums.Length-1; i++) // O(n^2)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                    continue;

                l = i+1;
                r = nums.Length - 1;
                while (l < r)
                {
                    sum = nums[l] + nums[r] + nums[i];
                    if (sum == 0)
                    {
                        res.Add(new int[] { nums[i], nums[l], nums[r] });

                        while (l < r && nums[l] == nums[l + 1])
                            l++;

                        while (l < r && nums[r] == nums[r - 1])
                            r--;

                        l++;
                        r--;
                    }
                    else if(sum < 0)
                        l++;
                    else
                        r--;
                }
                
            }

            return res;
        }
    }
}
