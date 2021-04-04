using System;

namespace MaximumSubarray
{
    class Program
    {
        public static int MaxSubArray(int[] nums) {
            int maxSum = int.MinValue;
            var sum = int.MinValue;
            for(int i = 0; i < nums.Length; i++)
            {
                if(nums[i] < 0){
                    if (nums[i] > sum)
                        sum = nums[i];
                    continue;
                }
                sum = nums[i];
                if(sum > maxSum)
                    maxSum = sum;
                for(int j = i + 1; j < nums.Length; j++)
                {
                    if(nums[j] > 0){
                        sum += nums[j];
                        if(sum > maxSum)
                            maxSum = sum;
                    }
                    else
                        sum += nums[j];
                }
            }
            if(sum > maxSum)
                return sum;
            else
                return maxSum;
        }
        static void Main(string[] args)
        {
            var nums = new int[]{5,4,-1,7,8};
            Console.WriteLine(MaxSubArray(nums));
        }
    }
}
