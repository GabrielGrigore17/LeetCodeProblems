using System;

namespace BestTimeToBuyAndSellStock
{
    class Program
    {
        static public int MaxProfit(int[] prices) 
        {
            var minPrice = int.MaxValue;
            var maxProfit = 0;
            for(int i = 0; i < prices.Length; i ++)
            {
                if(prices[i] < minPrice)
                    minPrice = prices[i];
                else if (prices[i] - minPrice > maxProfit)
                    maxProfit = prices[i] - minPrice;
            }
            return maxProfit;
        }
        static void Main(string[] args)
        {
            var prices = new int[]{7,1,5,3,6,4};
            Console.WriteLine(MaxProfit(prices));
        }
    }
}
