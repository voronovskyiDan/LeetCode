using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.easy
{
    class BuyAndSellStock
    {
        public static int Solution(int[] prices)
        {
            int res = 0, min = prices[0];

            for(int i = 1; i < prices.Length; i++)
            {
                if (prices[i] < min)
                {
                    min = prices[i];
                }
                else if(prices[i] - min > res)
                {
                    res = prices[i] - min;
                }
            }
            return res;
        }
    }
}
