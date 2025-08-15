using LeetCode.easy;
using LeetCode.mid;

namespace LeetCode;

internal class Program
{
    static void Main(string[] args)
    {
        int[] res = TwoSumTwo.Solution(new int[] { 2, 7, 11, 15 }, 9);

        for (int i = 0; i < res.Length; i++)
        {
            Console.WriteLine(res[i]);
        }
    }
}