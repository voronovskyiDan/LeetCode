using LeetCode.easy;
using LeetCode.mid;

namespace LeetCode;

internal class Program
{
    static void Main(string[] args)
    {
        int[][] res = InsertInterval.Solution(new int[][] {
                new int[] { 1, 3 },
                new int[] { 6, 9 },
            }, new int[] { 2, 5 });

        foreach(var group in res)
        {
            foreach(var it in group)
            {
                Console.Write(it + " ");
            }
            Console.WriteLine();
        }
    }
}