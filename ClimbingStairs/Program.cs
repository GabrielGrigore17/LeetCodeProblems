using System;

namespace ClimbingStairs
{
    class Program
    {
        public int ClimbStairs(int n) {
            int sum = 0;
            for(int i=0; i <= n/2; i++)
            {
                sum += (n - 2*i) * i + 1;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
