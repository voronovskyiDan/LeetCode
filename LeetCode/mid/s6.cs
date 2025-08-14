using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.mid
{
    class ZigZag
    {

        public static string Solution(string s, int numRows)
        {
            if (numRows == 1 || numRows >= s.Length)
            {
                return s;
            }

            List<List<char>> arrRes = new List<List<char>>(numRows);
            for (int i = 0; i < numRows; i++)
            {
                arrRes.Add(new List<char>());
            }


            int d = 1, rowIdx = 0;
            for(int i = 0; i < s.Length; i++)
            {
                arrRes[rowIdx].Add(s[i]);

                rowIdx += d;

                if (rowIdx == numRows - 1 ||rowIdx == 0)
                    d *= -1;
            }

            StringBuilder sRes = new StringBuilder();

            foreach(List<char> row in arrRes)
            {
                foreach (char ch in row)
                {
                    sRes.Append(ch);
                }
            }

            return sRes.ToString();
        }
    }
}
