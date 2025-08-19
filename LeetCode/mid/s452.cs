using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.mid
{
    class MinimalNumberOfArrowsToBurstBallons
    {
        public static int Solution(int[][] points)
        {
            /*if (points.Length == 0)
                return 0;
            if (points.Length == 1)
                return 1;

            List<int[]> res = new();

            Array.Sort(points, (l, r) => l[0].CompareTo(r[0]) );

            for(int i =0; i < points.Length; i++)
            {
                if(res.Count == 0 || points[i][0] > res[res.Count - 1][1] )
                {
                    res.Add(points[i]);
                }
                else
                {
                    res[res.Count - 1][1] = Math.Min(res[res.Count - 1][1], points[i][1]);
                }
            }

            return res.Count;*/

            if (points.Length == 0)
                return 0;
            if (points.Length == 1)
                return 1;

            Array.Sort(points, (l, r) => l[0].CompareTo(r[0]));

            int arrows = 1;
            int end = points[0][1];

            for(int i = 1; i < points.Length; i++)
            {
                if (points[i][0] > end)
                {
                    arrows++;
                    end = points[i][1];
                }
                else
                    end = Math.Min(end, points[i][1]);
            }
            return arrows;
        }
    }
}
