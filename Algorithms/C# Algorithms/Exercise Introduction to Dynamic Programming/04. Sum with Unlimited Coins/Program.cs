using System;
using System.Linq;

namespace _04._Sum_with_Unlimited_Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] coins = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(a => int.Parse(a))
                .ToArray();

            int targetSum = int.Parse(Console.ReadLine());

            int[] dp = new int[targetSum + 1];
            dp[0] = 1;

            for (int i = 0; i < coins.Length; i++)
            {
                for (int j = coins[i]; j <= targetSum; j++)
                {
                    dp[j] += dp[j - coins[i]];
                }
            }

            Console.WriteLine(dp[targetSum]);
        }
    }
}
