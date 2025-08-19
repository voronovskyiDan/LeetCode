using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.mid
{
    class MinStack
    {
        private LinkedList<MinNode> data;

        public MinStack()
        {
            data = new();

        }

        public void Push(int val)
        {
            int newMin = data.Count == 0 ? val : Math.Min(val, data.Last.Value.min);
            data.AddLast(new MinNode(val, newMin));
        }

        public void Pop()
        {
            data.RemoveLast();
        }

        public int Top()
        {
            return data.Last.Value.val;
        }

        public int GetMin()
        {
            return data.Last.Value.min;
        }
    }
    class MinNode
    {
        public MinNode(int val, int min)
        {
            this.val = val;
            this.min = min;
        }

        public int val { get; set; }
        public int min { get; set; }
    }
}
