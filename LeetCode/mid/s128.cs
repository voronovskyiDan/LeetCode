using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.mid
{
    class LongestConsecutiveSequence
    {
        public static int Solution(int[] nums)
        {
            HashSet<int> values = new HashSet<int>(nums);
            int max = 0;

            foreach(var num in values)
            {
                if (!values.Contains(num - 1))
                {
                    int count = 0;
                    int currnet = num;

                    while (values.Contains(currnet))
                    {
                        currnet++;
                        count++;
                    }

                    max = Math.Max(max, count);
                }
            }

            return max;
        }
    }
}
