using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.easy
{
    class RansomNote
    {
        public static bool Solution(string ransomNote, string magazine)
        {
            //Preprocessing map

            //Just Faster =)
            /*int[] map = new int[128];
            for (int i = 0; i < magazine.Length; i++)
            {
                map[magazine[i]]++;
            }
            for (int i = 0; i < ransomNote.Length; i++)
            {
                if (map[ransomNote[i]] != 0)
                    map[ransomNote[i]]--;
                else
                    return false;
            }*/


            //Normal, boring and slooooww -_-
            Dictionary<char, int> map = new(magazine.Length);
            foreach (var c in magazine)
            {
                if (map.ContainsKey(c))
                    map[c]++;
                else
                    map.Add(c, 1);
            }
            foreach (var c in ransomNote)
            {
                if (!map.ContainsKey(c) || map[c] == 0)
                    return false;
                map[c]--;
            }
            return true;
        }
    }
}
