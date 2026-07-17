using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.mid
{
    internal class SingleNumberIII
    {
        public static int[] Solution(int[] nums)
        {
            int xor = 0;
            foreach (int num in nums)
            {
                xor ^= num;
            }

            int diffBit = xor & -xor;
            int[] result = new int[2];
            foreach (int num in nums)
            {
                if ((num & diffBit) == 0)
                {
                    result[0] ^= num;
                }
                else
                {
                    result[1] ^= num;
                }
            }
            return result;
        }
    }
}
