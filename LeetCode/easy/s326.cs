using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.easy
{
	internal class IsPowerOfThree
	{
		public static bool Solution(int n)
		{
			if(Math.Log10(n)/Math.Log10(3) % 1 == 0)
				return true;
			return false;
		}
	}
}
