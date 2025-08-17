using LeetCode.easy;
using LeetCode.mid;

namespace LeetCode;

internal class Program
{
    static void Main(string[] args)
    {
        bool res = ValidAnagram.Solution("anagram", "nagaram");

        Console.WriteLine(res);
    }
}