using System;
using System.Collections.Generic;

namespace TwoSum
{
    class Program
    {
        static public int[] TwoSum(int[] nums, int target) 
        {
           var map = new Dictionary<int, int>();
           for (int i = 0; i < nums.Length; i++){
               int complement = target - nums[i];
               if(map.ContainsKey(complement)){
                   return new int[] {map[complement], i};
               }
               map.Add(nums[i], i);
           }
           throw new ArgumentException("The arguments parsed are not valid!");
        }
        static void Main(string[] args)
        {
            var nums1 = new int[]{2, 7, 11, 15};
            var nums2 = new int[]{3, 2, 4};
            var nums3 = new int[]{3, 3};

            var res1 = TwoSum(nums1, 9);

            foreach(var num in res1)
                Console.WriteLine(num);
        }
    }
}
