using LeetCode.easy;
using LeetCode.mid;

namespace LeetCode;

internal class Program
{
    static void Main(string[] args)
    {
        IList<IList<int>> res = FourSum.Solution(new int[] { 1, 0, -1, 0, -2, 2 }, 0);

        foreach(var list in res)
        {
            foreach(var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

        }
    }
}