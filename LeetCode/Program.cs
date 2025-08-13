using LeetCode.easy;
using LeetCode.mid;

namespace LeetCode;

internal class Program
{
    static void Main(string[] args)
    {
        int[] res = ProductOfArrayExceptSelf.Solution(new int[] { 1, 2, 3, 4 });
        foreach(int it in res)
            Console.WriteLine(it);
    }
}