using LeetCode.easy;
using LeetCode.mid;

namespace LeetCode;

internal class Program
{
    static void Main(string[] args)
    {
        IList<IList<string>> res = GroupAnagram.Solution(new string[] { "abets", "bead", "remain", "betas", "abed", "baste", "airline", "leading", "beast", "dealing", "beats", "airmen", "marine", "single", "bade", "aligned" });

        foreach(var group in res)
        {
            foreach(var an in group)
            {
                Console.Write(an + " ");
            }
            Console.WriteLine();
        }
    }
}