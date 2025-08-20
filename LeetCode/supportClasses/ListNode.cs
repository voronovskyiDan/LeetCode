using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.supportClasses
{
    public class ListNode
    {
        public int val { get; set; }
        public ListNode? next { get; set; }
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
        public ListNode(int val) : this(val, null) { }
    }
}