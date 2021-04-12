using System;
using System.Collections.Generic;

namespace MajorityElement
{
    class Program
    {
        public int MajorityElement(int[] nums) {
            var dict = new Dictionary<int, int>();
            int max = 0;
            int output = -1;
            for(int i = 0; i < nums.Length; i++){
                if(dict.ContainsKey(nums[i])){
                    dict[nums[i]]++;
                    if(dict[nums[i]] > max){
                        max = dict[nums[i]];
                        output = nums[i];
                    }
                }
                else{
                    dict.Add(nums[i], 1);
                    if(dict[nums[i]] > max){
                        max = dict[nums[i]];
                        output = nums[i];
                    }
                }
            }
            return output;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
