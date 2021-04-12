using System;

namespace BestTimeToBuyAndSellStockTwo
{
    class Program
    {
        public static int MaxProfit(int[] prices) {
            int sellPoint = 0;
            int buyPoint = int.MaxValue;
            int profit = 0;
            bool exit = false;
            for(int i = prices.Length - 1; i >=0; i--){
                if(prices[i] > sellPoint){
                    sellPoint = prices[i];
                    continue;
                }
                while(prices[i] < buyPoint){
                    buyPoint = prices[i];
                    if(i != 0){
                        i--;
                        continue;
                    }
                    else{
                        exit = true;
                        break;
                    }                 
                }
                Console.WriteLine(sellPoint.ToString() + " " + buyPoint.ToString());
                profit += sellPoint - buyPoint;
                if(exit)
                    break;
                sellPoint = prices[i];
                buyPoint = int.MaxValue;
            }
            return profit;
        }
        static void Main(string[] args)
        {
            int[] prices = new int[] {7,1,5,3,6,4};
            Console.WriteLine(MaxProfit(prices));
        }
    }
}
