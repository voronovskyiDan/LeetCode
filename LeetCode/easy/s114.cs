using LeetCode.supportClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.easy
{
    class LinkedListCycle
    {
        public static bool Solution(ListNode head)
        {
            if (head == null) return false;

            ListNode? slow = head, fast = head;
            while (fast?.next != null)
            {
                slow = slow?.next;
                fast = fast.next?.next;

                if (slow == fast) return true;
            }

            return false;
        }
    }
}
