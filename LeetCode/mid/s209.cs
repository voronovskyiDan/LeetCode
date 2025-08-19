using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.mid
{
    class MinimumSizeSubarraySum
    {
        public static int Solution(int target, int[] nums)
        {
            //O(n*log(n))
            Array.Sort(nums);
            int l = 0, r = nums.Length - 1, mid, sum = int.MinValue;

            while (sum < target && l < r)
            {
                sum = nums[l] + nums[r];
                mid = (l + r) / 2;
                if (sum < target)
                {
                    l = mid + 1;
                }
                else if(sum > target)
                {
                    r = mid - 1;
                }
            }

            return r - l;

            //O(n)
                /*int n = nums.Length;
                int left = 0, sum = 0, minLen = int.MaxValue;

                for (int right = 0; right < n; right++)
                {
                    sum += nums[right];
                    while (sum >= target)
                    {
                        minLen = Math.Min(minLen, right - left + 1);
                        sum -= nums[left++];
                    }
                }

                return minLen == int.MaxValue ? 0 : minLen;*/

                //O(n)
                /* int n = nums.Length;
                 for (int i = 1; i < n; i++)
                 {
                     nums[i] += nums[i - 1];
                 }

                 if (nums[n - 1] < target)
                     return 0;

                 int min = n;
                 int r = nums.Length - 1, l = r-1;
                 while(l > 0) 
                 {
                     int compVal = nums[r] - nums[l];
                     if (compVal < target)
                     {
                         l--;
                     }
                     else
                     {
                         min = Math.Min(min, r - l);
                         r--;
                     }
                 }

                 while(r >= 0)
                 {
                     if (nums[r] >= target)
                         min = Math.Min(min, r + 1);
                     r--;
                 }

                 return min;*/
        }
    }
}
