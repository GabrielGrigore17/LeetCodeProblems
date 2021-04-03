using System;

namespace TwoSumTwo
{
    class Program
    {
        static public int[] TwoSum(int[] numbers, int target){
            var endSearchIndex = numbers.Length - 1;
            for (int i = 0; i < numbers.Length; i++){
                var complement = target - numbers[i];
                for(int j = endSearchIndex; j >= 0; j--){
                    if(numbers[j] > complement)
                        endSearchIndex = j-1;
                    else
                        if(numbers[j] == complement)
                            return new int[] {i+1, j+1};
                        else
                            break;
                }
            }
            throw new ArgumentException("The arguments are not valid");
        }
        static void Main(string[] args)
        {
            var nums1 = new int[]{2, 7, 11, 15};
            var res1 = TwoSum(nums1, 9);
            foreach(var num in res1)
                Console.WriteLine(num);
        }
    }
}
