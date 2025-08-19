using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.mid
{
    class EvalRPN
    {
        public static int Solution(string[] tokens)
        {
            Stack<int> stack = new();

            foreach(var token in tokens)
            {
                if (int.TryParse(token, out int number))
                {
                    stack.Push(number);
                }
                else
                {
                    int secondNumber = stack.Pop();
                    int firstNumber = stack.Pop();
                    switch (token)
                    {
                        case "+":
                            stack.Push(firstNumber + secondNumber);
                            break;
                        case "-":
                            stack.Push(firstNumber - secondNumber);
                            break;
                        case "*":
                            stack.Push(firstNumber * secondNumber);
                            break;
                        case "/":
                            stack.Push(firstNumber / secondNumber);
                            break;
                    }
                    
                }
            }

            return stack.Peek();
        }
    }
}
