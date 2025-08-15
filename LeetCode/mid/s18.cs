using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.mid
{
    class FourSum
    {
        public static IList<IList<int>> Solution(int[] nums, int target)
        {
            List<IList<int>> res = new();

            Array.Sort(nums);

            int l, r;
            long sum;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                    continue;

                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (j > i+1 && nums[j] == nums[j - 1])
                        continue;

                    l = j + 1;
                    r = nums.Length - 1;
                    while (l < r)
                    {
                        sum = 0;
                        sum += nums[i];
                        sum += nums[j];
                        sum += nums[l];
                        sum += nums[r];

                        if (sum < target)
                            l++;
                        else if (sum > target)
                            r--;
                        else
                        {
                            res.Add(new int[] { nums[i], nums[j], nums[l], nums[r] });

                            while (l < r && nums[l] == nums[l + 1])
                                l++;
                            while (l < r && nums[r] == nums[r - 1])
                                r--;

                            l++;
                            r--;
                        }

                    }
                }
            }
            return res;
        }
    }
}



/*int l, r;
long sum;
for (int i = 0; i < nums.Length; i++)
{
    if (i > 0 && nums[i] == nums[i - 1])
        continue;

    for (int j = i + 1; j < nums.Length; j++)
    {
        if (j > i + 1 && nums[j] == nums[j - 1])
            continue;

        l = j + 1;
        r = nums.Length - 1;
        sum = 0;
        while (l < r)
        {
            sum += nums[i];
            sum += nums[j];
            sum += nums[l];
            sum += nums[r];

            if (sum < target)
                l++;
            else if (sum > target)
                r--;
            else
            {
                res.Add(new int[] { nums[i], nums[j], nums[l], nums[r] });

                while (l < r && nums[l] == nums[l + 1])
                    l++;
                while (l < r && nums[r] == nums[r - 1])
                    r--;

                l++;
                r--;
            }

        }
    }
}
return res*/;