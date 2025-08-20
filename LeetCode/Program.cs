using LeetCode.easy;
using LeetCode.mid;
using LeetCode.supportClasses;

namespace LeetCode;

internal class Program
{
    static void Main(string[] args)
    {
        /* ListNode root = new ListNode(3);
         ListNode cycleNode = new ListNode(2);
         ListNode cycleNode2 = new ListNode(0);
         ListNode cycleNode3 = new ListNode(4);

         root.next = cycleNode;
         cycleNode.next = cycleNode2;
         cycleNode2.next = cycleNode3;
         cycleNode3.next = cycleNode;*/
        ListNode root = new ListNode(1);
        ListNode cycleNode = new ListNode(2);

        root.next = cycleNode;
        cycleNode.next = null;

        bool res = LinkedListCycle.Solution(root);
        Console.WriteLine(res);
    }
}