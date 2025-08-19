using LeetCode.easy;
using LeetCode.mid;
using LeetCode.supportClasses;

namespace LeetCode;

internal class Program
{
    static void Main(string[] args)
    {
        int res = EvalRPN.Solution(new string[] { "2", "1", "+", "3", "*" });
        Console.WriteLine(res);
    }
}