using System;

namespace RunningSumOf1dArray
{
    class Program
    {
        public int[] RunningSum(int[] nums) {
            int sum = 0;
            for(int i = 0; i < nums.Length; i++){
                sum += nums[i];
            }
            return nums;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
