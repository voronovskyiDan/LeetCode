using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.mid
{
	internal class RotateArray
	{
        static int gcd(int a, int b) {
            return b == 0 ? a : gcd(b, a % b);
        }
        public static int[] Solution(int[] nums, int k)
		{
            int n = nums.Length;
            k %= n;

            if (k == 0)
                return nums;

            for(int i = 0; i < gcd(n, k); i++)
            {
                int curr = i;
                int prev = nums[i];

                do
                {
                    int next = (curr + k) % n;
                    int temp = nums[next];
                    nums[next] = prev;
                    prev = temp;
                    curr = next;
                } while (i != curr);
            }
            return nums;
        }
		
	}
}