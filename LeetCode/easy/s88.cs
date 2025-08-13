using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.easy
{
    class MergeSortedArray
    {
        public static int[] Solution(int[] nums1, int m, int[] nums2, int n)
        {
            while(n > 0)
            {                   
                if(m > 0 && nums1[m - 1] > nums2[n - 1])
                {
                    nums1[m + n - 1] = nums1[m - 1];
                    m--;
                }
                else
                {
                    nums1[m + n - 1] = nums2[n - 1];
                    n--;
                    
                }
            }

            return nums1;
        }
    }
}
