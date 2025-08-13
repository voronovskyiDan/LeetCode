using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.mid
{
    class GasStation
    {
        public static int Solution(int[] gas, int[] cost)
        {
            int total = 0;
            int tank = 0;
            int start = 0;

            for (int i = 0; i < gas.Length; i++)
            {
                int diff = gas[i] - cost[i];
                total += diff;
                tank += diff;

                if (tank < 0)
                {
                    start = i + 1;
                    tank = 0;
                }
            }

            return total >= 0 ? start : -1;
        }
    }
}
