using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Input: n = 15
Output: ["1","2","Fizz","4","Buzz","Fizz","7","8","Fizz","Buzz","11","Fizz","13","14","FizzBuzz"]
*/
namespace LeetCode.easy
{
	internal class FizzBuzz
	{
		public static IList<string> Solution(int n)
		{
			List<string> res = new();
			for(int i = 1; i <= n; i++)
			{
				StringBuilder sb = new StringBuilder();
				if(i%3 == 0)
					sb.Append("Fizz");
				if (i%5 == 0)
					sb.Append("Buzz");
				if(sb.Length == 0)
					sb.Append(i);

				res.Add(sb.ToString());
			}
			return res;
		}
	}
}
