using LeetCode.easy;
using LeetCode.mid;
using LeetCode.supportClasses;

namespace LeetCode;

internal class Program
{
    static void Main(string[] args)
    {
        int res = MinimalNumberOfArrowsToBurstBallons.Solution(new int[][]
        {
            new int[]{ 10,16 },
            new int[]{ 2,8 },
            new int[]{ 1,6 },
            new int[] { 7, 12 }
        });
        Console.WriteLine(res);
    }
}