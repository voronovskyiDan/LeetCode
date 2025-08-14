using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.easy
{

/*
	Symbol Value
	I             1
	V             5
	X             10
	L             50
	C             100
	D             500
	M             1000
*/

	internal class RomanToInt
	{
		static int[] map;
		public RomanToInt()
		{
			map = new int[100];
			map['I'] = 1;
			map['V'] = 5;
			map['X'] = 10;
			map['L'] = 50;
			map['C'] = 100;
			map['D'] = 500;
			map['M'] = 1000;
        }

        public static int Solution(string s)
		{
			int res = 0;
			int lastVal = 0;

			for(int i = s.Length - 1; i >= 0; i--)
			{
				int currentVal = map[s[i]];
				if (lastVal > currentVal)
				{
					res += currentVal;
                    lastVal = currentVal;
                }
                else
				{
					res -= currentVal;
				}
			}

			return res;
		}
	}
}
