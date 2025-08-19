using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.mid
{
    class SimplifyPath
    {
        public static string Solution(string path)
        {
            StringBuilder res = new();
            Stack<string> rearranged = new();

            string[] parts = path.Split('/');

           foreach(var part in parts)
           {
                if (part == "" || part == ".")
                    continue;
                if (part == "..")
                {
                    if(rearranged.Count != 0)
                        rearranged.Pop();
                    continue;
                }

                rearranged.Push(part);
           }

           while(rearranged.Count != 0)
           {
                res.Insert(0,"/" + rearranged.Pop());
           }
            return res.Length == 0 ? "/" : res.ToString();
        }
    }
}
