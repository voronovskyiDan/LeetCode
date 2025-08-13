using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.mid
{
    class AddTwoNumber
    {
        public class ListNode {
            public int val;
             public ListNode next;
             public ListNode(int val=0, ListNode next=null) {
                  this.val = val;
                  this.next = next;
              }
        }
        public static ListNode Solution(ListNode l1, ListNode l2) {
            int sum = 0, bias = 0;

            ListNode result = null;
            ListNode prev = null;
            while (l1 != null || l2 != null)
            {
                int fisrtVal = l1 != null ? l1.val : 0;
                int secondVal = l2 != null ? l2.val : 0;

                int paralelSum = fisrtVal + secondVal + bias;
                bias = 0;

                ListNode node = new ListNode(0, null);

                if (paralelSum / 10 != 0)
                {
                    node.val = paralelSum % 10;
                    bias = 1;
                }
                else
                {
                    node.val = paralelSum;
                }


                if (result == null)
                {
                    result = node;
                }
                else
                {
                    prev.next = node;
                }
                prev = node;

                if(l1 != null)
                    l1 = l1.next;
                if (l2 != null)
                    l2 = l2.next;

                if(bias != 0 && l1 == null && l2 == null)
                {
                    prev.next = new ListNode(bias, null);
                }
            }
            return result;

            /*
            ListNode result = null;
            ListNode prev = null;

            while (sum > 0)
            {
                ListNode node = new ListNode(sum % 10, null);

                if (result == null)
                {
                    result = node;
                }
                else
                {
                    prev.next = node;
                }
                prev = node;

                sum /= 10;
            }
            return result;
            */
        }
    }
}
