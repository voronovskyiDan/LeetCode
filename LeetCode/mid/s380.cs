using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.mid
{
    class RandomizedSet
    {
        private Dictionary<int, int> valueIndices;
        private List<int> values;
        private Random rand ;
        public RandomizedSet()
        {
            valueIndices = new(512);
            values = new(512);
            rand = new();
        }

        public bool Insert(int val)
        {
            if (valueIndices.ContainsKey(val))
                return false;

            values.Add(val);
            valueIndices.Add(val, values.Count - 1);
            return true;
        }

        public bool Remove(int val)
        {
            if (!valueIndices.ContainsKey(val))
                return false;
            
            int indexToRemove = valueIndices[val];
            int lastValue = values[values.Count - 1];

            values[indexToRemove] = lastValue;
            valueIndices[lastValue] = indexToRemove;

            valueIndices.Remove(val);
            values.RemoveAt(values.Count - 1);

            return true;
        }

        public int GetRandom()
        {
            return values[rand.Next(0, values.Count)];
        }
    }
}
