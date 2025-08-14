using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.mid
{
    class ReverseWordsInSting
    {
        public static string Solution(string s)
        {
            StringBuilder res = new();

            int begin = s.Length - 1, end = s.Length - 1;

            while(end >= 0)
            {

                if (s[end] == ' ')
                {
                    end--;
                }
                else
                {
                    begin = end;
                    while (begin >= 0 && s[begin] != ' ' )
                    {
                        begin--;
                    }

                    res.Append(s.Substring(begin+1, end-begin));
                    res.Append(" ");

                    end = begin;
                }
            }

            res.Remove(res.Length - 1, 1);
            return res.ToString();
        }
    }
}
