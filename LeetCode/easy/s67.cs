using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCode.easy
{
    class AddBinary
    {
        public static string Solution(string a, string b)
        {
            StringBuilder res = new();

            int d = 0;
            int i = a.Length-1, j = b.Length-1;
            while (i >= 0 || j >= 0 || d > 0)
            {
                int bitA = (i >= 0) ? a[i] - '0' : 0;
                int bitB = (j >= 0) ? b[j] - '0' : 0;

                int sum = bitA + bitB + d; 
                res.Insert(0, (sum % 2).ToString()); 
                d = sum / 2;
                i--;
                j--;
            }


            return res.ToString();
        }
    }
}
