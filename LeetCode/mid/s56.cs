using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.mid
{
    class MergeIntervals
    {
        public static int[][] Solution(int[][] intervals)
        {
            List<int[]> res = new();

            if (intervals.Length == 0)
                return res.ToArray();

            Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0])); //O(n * log(n))

            for(int i = 0; i < intervals.Length; i++)
            {
                if (res.Count == 0 || intervals[i][0] > res[res.Count - 1][1])
                {
                    res.Add(new int[] { intervals[i][0], intervals[i][1] });
                }
                else
                {
                    res[res.Count - 1][1] = Math.Max(res[res.Count - 1][1], intervals[i][1]);
                }
            }
            return res.ToArray();
        }
    }
}
