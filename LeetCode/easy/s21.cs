using LeetCode.supportClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.easy
{
    class MergeTwoSortedList
    {
        public static ListNode Solution(ListNode list1, ListNode list2)
        {
            ListNode res = null, prev = null;
            int min;
            while (list1 != null || list2 != null)
            {

                if (list1 != null && (list2 == null || list1.val <= list2.val))
                {
                    min = list1.val;
                    list1 = list1.next;
                }
                else
                {
                    min = list2.val;
                    list2 = list2.next;
                }

                if (res == null)
                {
                    res = new ListNode(min, null);
                    prev = res;
                }
                else
                {
                    prev.next = new ListNode(min, null);
                    prev = prev.next;
                }
            }

            return res;
        }
    }
}
