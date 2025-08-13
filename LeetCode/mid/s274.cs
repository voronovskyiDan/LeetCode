using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.mid
{
    class HIndex
    {
        public static int Solution(int[] citations)
        {
            citations = countsort(citations);

            int res = 0;
            for (int i = citations.Length - 1; i >= 0; i--)
            {
                if (citations[i] <= res)
                    return res;
                res++;
            }
            return res;
        }
        public static int[] countsort(int[] arr)
        {
            int n = arr.Length;

            int maxval = 0;
            for (int i = 0; i < n; i++)
                maxval = Math.Max(maxval, arr[i]);

            int[] count = new int[maxval + 1];
            for (int i = 0; i < n; i++)
                count[arr[i]]++;

            for(int i = 1; i <= maxval; i++)
                count[i] += count[i - 1];

            int[] ans = new int[n];
            for (int i = n - 1; i >= 0; i--)
            {
                int val = arr[i];
                ans[count[val] - 1] = val;
                count[val]--;
            }

            return ans;
        }
    }
}
