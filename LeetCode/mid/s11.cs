using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.mid
{
    class ContainerWithMostWater
    {
        public static int Solution(int[] height)
        {
            int l = 0, r = height.Length - 1;
            int max = 0;

            while (l < r)
            {
                if (height[l] <= height[r])
                {
                    max = Math.Max(max, height[l] * (r - l));
                    l++;
                }
                else
                {
                    max = Math.Max(max, height[r] * (r - l));
                    r--;
                }
            }

            return max;
        }
    }
}
