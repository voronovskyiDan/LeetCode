using LeetCode.easy;
using LeetCode.mid;

namespace LeetCode;

internal class Program
{
    static void Main(string[] args)
    {
        int res = ContainerWithMostWater.Solution(new int[] { 1, 2, 3, 1000, 9 });

        Console.WriteLine(res);
    }
}