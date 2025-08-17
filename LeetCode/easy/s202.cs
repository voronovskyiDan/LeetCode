using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.easy
{
    class HappyNumber
    {
        public static bool Solution(int n)
        {
            // HASHSET
            /* HashSet<int> map = new();

             while(n != 1)
             {
                 if (!map.Add(n))
                     return false;
                 n = countSquaredSum(n);

             }

             return true;*/

            //FLOYD`S CYCLE FINDING ALG
            int slow = n, fast = n;

            while (slow != fast)
            {
                slow = countSquaredSum(slow);
                fast = countSquaredSum(countSquaredSum(fast));

                if (fast == 1)
                    return true;
            }

            return slow == 1;
        }

        private static int countSquaredSum(int n)
        {
            int sum = 0, tmp;
            while (n != 0)
            {
                tmp = n % 10;
                sum += tmp * tmp;
                n /= 10;
            }
            return sum;
        }
    }
}
