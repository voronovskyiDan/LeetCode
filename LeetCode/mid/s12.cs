using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.mid
{

   /* 
    I	1
    V	5
    X	10
    L	50
    C	100
    D	500
    M	1000
   */

    class IntigerToRoman
    {
        private static int[] values = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        private static String[] symbols = {"M", "CM", "D",  "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I"};

        public static string Solution(int num)
        {
            StringBuilder res = new();

            for(int i = 0; i < values.Length; i++)
            {
                if (num == 0)
                    break;
                while (num >= values[i])
                {
                    res.Append(symbols[i]);
                    num -= values[i];
                }
            }

            return res.ToString();
        }
    }
}
