using LeetCode.easy;
using LeetCode.mid;

namespace LeetCode;

internal class Program
{
    static void Main(string[] args)
    {
        /*bool res = ContainsDublicatesTwo.Solution(new int[] { 1, 2, 3, 1, 2, 3 }, 2);
        Console.WriteLine(res);*/

        int val = 9; 

        RandomizedSet obj = new RandomizedSet();
        bool param_1 = obj.Insert(val);
        bool param_2 = obj.Remove(val);
        int param_3 = obj.GetRandom();
        Console.WriteLine(param_1);
        Console.WriteLine(param_2);
        Console.WriteLine(param_3);
    }
}