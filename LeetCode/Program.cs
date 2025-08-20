using LeetCode.easy;
using LeetCode.mid;
using LeetCode.supportClasses;

namespace LeetCode;

internal class Program
{
    static void Main(string[] args)
    {
         ListNode root1 = new ListNode(1);
         ListNode cycleNode1 = new ListNode(2);
         ListNode cycleNode2 = new ListNode(4);

         root1.next = cycleNode1;
         cycleNode1.next = cycleNode2;

        ListNode root2 = new ListNode(1);
        ListNode cycleNode2_1 = new ListNode(3);
        ListNode cycleNode2_2 = new ListNode(4);

        root2.next = cycleNode2;
        cycleNode2_1.next = cycleNode2_2;

        ListNode res = MergeTwoSortedList.Solution(root1, root2);
        while(res != null)
        {
            Console.Write(res.val + " ");
            res = res.next;
        }
    }
}