using System;

class Program
{
    static void Main(string[] args)
    {
        int[] TwoCoins(int[] coins, int target)
        {
            for (int curr = 0; curr < coins.Length; curr++)
            {
                for (int next = curr + 1; next < coins.Length; next++)
                {
                    return new int[]{curr, next};
                }
            }
            return new int[0];
        }
    }
}