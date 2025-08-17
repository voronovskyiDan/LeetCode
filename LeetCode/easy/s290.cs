using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.easy
{
    class WordPattern
    {
        public static bool Solution(string pattern, string s)
        {
            //BIDIRECTIONAL MAPPING O(n)
            /*Dictionary<string, char> mapToChars = new();
            Dictionary<char, string> mapToWords = new();
            string[] words = s.Split(" ");

            if (words.Length != pattern.Length)
                return false;

            for (int i = 0; i < words.Length; i++)
            {
                if (!mapToChars.ContainsKey(words[i]) && !mapToWords.ContainsKey(pattern[i]))
                {
                    mapToChars.Add(words[i], pattern[i]);
                    mapToWords.Add(pattern[i], words[i]);
                }
                else if (mapToWords.ContainsKey(pattern[i]) && mapToWords[pattern[i]] != words[i])
                    return false;
                else if (mapToChars.ContainsKey(words[i]) && mapToChars[words[i]] != pattern[i])
                    return false;
            }
            return true;*/


            //O(n^2)
            Dictionary<char,string> map = new();
            string[] words = s.Split(" ");

            if (words.Length != pattern.Length)
                return false;

            for (int i = 0; i < pattern.Length; i++) //O(n)
            {
                if (map.ContainsKey(pattern[i]))
                {
                    if (map[pattern[i]] != words[i]) return false;
                }
                else
                {
                    if (map.ContainsValue(words[i])) return false; //O(n)
                    map.Add(pattern[i], words[i]);
                }
            }

            return true;
        }
    }
}
