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
		public static int Solution(string s)
		{
			Dictionary<char, int> map = new Dictionary<char, int>()
			{
				{ 'I', 1 },
				{ 'V', 5 },
				{ 'X', 10 },
				{ 'L', 50 },
				{ 'C', 100 },
				{ 'D', 500 },
				{ 'M', 1000 },
			};

			int res = 0;

			char[] v = s.ToCharArray();
			for(int i = 0; i < v.Length; i++)
			{
				int currentVal = map[v[i]];
				if (v.Length > 1 && i != v.Length-1)
				{
					if (currentVal < map[v[i + 1]])
						res -= currentVal;
					else
						res += currentVal;
				}
				else
				{
					res += currentVal;
				}
			}

			return res;
		}
	}
}
