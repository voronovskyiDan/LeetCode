using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.easy
{
    class ValidParentheses
    {
        public static bool Solution(string s)
        {
            Stack<char> stack = new();
            foreach(char ch in s)
            {
                if(ch == '{' || ch == '[' || ch == '(')
                {
                    stack.Push(ch);
                }
                else
                {
                    if (stack.Count == 0)
                        return false;

                    char val = stack.Pop();
                    if (ch == ']' && val != '[')
                        return false;
                    if(ch == ')' && val != '(')
                        return false;
                    if (ch == '}' && val != '{')
                        return false;

                }
            }

            return stack.Count == 0;
        }
    }
}
