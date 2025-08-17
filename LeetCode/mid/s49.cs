using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.mid
{
    class GroupAnagram
    {
        public static IList<IList<string>> Solution(string[] strs)
        {
            //O(n*k) -> O(n)
            Dictionary<string, List<string>> map = new();
            
            foreach (var str in strs)
            {
                char[] freq = new char[26];
                foreach (char c in str)
                    freq[c - 'a']++;

                //If I supposed to use Dictionary
                //map.Values.ToArray();            

                string key = new string(freq);

                if (!map.ContainsKey(key))
                    map[key] = new List<string>();

                map[key].Add(str);
            }

            return map.Values.Cast<IList<string>>().ToList();


            //O(n*log(k)*k) -> O(n * log(n))
            /*Dictionary<string, List<string>> map = new();

            foreach (var str in strs)
            {
                string key = new string(str.OrderBy(c => c).ToArray());

                if (!map.ContainsKey(key))
                    map[key] = new List<string>();

                map[key].Add(str);
            }

            return map.Values.Cast<IList<string>>().ToList();*/


            //O(n^2)
            /*List<IList<string>> res = new();
            
            bool isNewGroup;
            bool isInGroup;

            for (int i = 0; i < strs.Length; i++)
            {
                Dictionary<char, int> map = new();
                string str = strs[i];
                for (int k = 0; k < str.Length; k++)
                {
                    if (!map.ContainsKey(str[k]))
                        map.Add(str[k], 1);
                    else
                        map[str[k]]++;
                }
                
                isNewGroup = true;
                for (int j = 0; j < res.Count; j++)
                {
                    Dictionary<char, int> internalMap = new Dictionary<char, int>(map);
                    string groupPattern = res[j][0];
                    isInGroup = true;

                    if (str.Length != groupPattern.Length)
                        continue;

                    for(int m = 0; m < str.Length; m++)
                    {
                        if (!internalMap.ContainsKey(groupPattern[m]))
                        {
                            isInGroup = false;
                            break;
                        }

                        int c = --internalMap[groupPattern[m]];
                        if (c < 0)
                        {
                            isInGroup = false;
                            break;
                        }
                    }
                    if (isInGroup)
                    {
                        res[j].Add(str);
                        isNewGroup = false;
                    }
                }
                if (isNewGroup)
                {
                    res.Add(new List<string>() { str });
                }
            }

            return res;*/
        }
    }
}
