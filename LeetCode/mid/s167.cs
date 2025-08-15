using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.mid
{
    class TwoSumTwo
    {
        public static int[] Solution(int[] numbers, int target)
        {
            int l = 0, r = numbers.Length - 1;
            int curr = 0;

            while (l < r)
            {
                curr = numbers[l] + numbers[r];
                if (curr == target)
                    break;
                else if (curr < target)
                    l++;
                else
                    r--;
            }

            return new int[]{l+1,r+1};
        }
    }
}
