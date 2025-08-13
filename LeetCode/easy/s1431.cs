using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.easy
{
    internal class KidsWithCandies
    {
        public static IList<bool> Solution(int[] candies, int extraCandies)
        {
            bool[] res = new bool[candies.Length];
            Array.Fill(res, false);

            int max = candies.Max();

            for(int i = 0; i < candies.Length; i++)
            {
                if (candies[i] + extraCandies > max)
                    res[i] = true;
            }

            return res;
        }
    }
}
