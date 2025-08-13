using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.mid
{
    internal class CountPrimes
    {
        public static int Solution(int n)
        {
            bool[] dp = new bool[n]; 
            Array.Fill(dp, true);

            for (int i = 2; i * i < n  ; i++)
            {
                if (dp[i])
                {
                    for (int j = i * i; j < n; j += i)
                        dp[j] = false;
                }
            }

            int cnt = 0;
            for (int i = 2; i < n; i++)
            {
                if (dp[i])
                    cnt++;
            }

            return cnt;
        }
    }
}
