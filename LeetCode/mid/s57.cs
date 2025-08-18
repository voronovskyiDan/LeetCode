using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.mid
{
    class InsertInterval
    {
        public static int[][] Solution(int[][] intervals, int[] newInterval)
        {

            //BINARY SEARCH APPROACH O(n+log(n)) -> O(n) -> min complexity is better

            if (intervals.Length == 0)
            {
                return new int[][] { newInterval };
            }

            int n = intervals.Length;
            int target = newInterval[0];
            int left = 0, right = n - 1;

            while(left <= right)
            {
                int mid = (left + right) / 2;
                if (intervals[mid][0] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            List<int[]> result = new List<int[]>();
            for (int i = 0; i < left; i++)
            {
                result.Add(intervals[i]);
            }

            result.Add(newInterval);
            for (int i = left; i < n; i++)
            {
                result.Add(intervals[i]);
            }

            List<int[]> merged = new List<int[]>();
            foreach (int[] interval in result)
            {
                if (merged.Count == 0 ||merged[merged.Count - 1][1] < interval[0])
                {
                    merged.Add(interval);
                }
                else
                {
                    merged[merged.Count - 1][1] =
                        Math.Max(merged[merged.Count - 1][1], interval[1]);
                }
            }

            return merged.ToArray();

            //LINEAR APPROACH O(n) -> avg complexity is better
            /*List<int[]> res = new List<int[]>();

            int i = 0, n = intervals.Length;
            while(i < n && intervals[i][1] < newInterval[0])
            {
                res.Add(intervals[i]);
                i++;
            }

            while (i < n && newInterval[1] >= intervals[i][0])
            {
                newInterval[0] = Math.Min(newInterval[0], intervals[i][0]);
                newInterval[1] = Math.Max(newInterval[1], intervals[i][1]);
                i++;
            }
            res.Add(newInterval);

            while (i < n) 
            {
                res.Add(intervals[i]);
                i++;
            }

            return res.ToArray();*/
        }
    }
}
