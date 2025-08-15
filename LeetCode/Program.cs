using LeetCode.easy;
using LeetCode.mid;

namespace LeetCode;

internal class Program
{
    static void Main(string[] args)
    {
        IList<IList<int>> res = ThreeSum.Solution(new int[] { 0, 0, 0, 0 });

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