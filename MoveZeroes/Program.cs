using System;

namespace MoveZeroes
{
    class Program
    {
        public static void MoveZeroes(int[] nums) {
            
            for(int i = 0; i < nums.Length; i++)
            {
                int numberOfZeroes = 0;
                while(nums[i] == 0 && i + numberOfZeroes + 1 < nums.Length){
                    numberOfZeroes++;
                    var aux = nums[i];
                    nums[i] = nums[i + numberOfZeroes];
                    nums[i + numberOfZeroes] = aux;
                }
            }
        }
        static void Main(string[] args)
        {
            var nums = new int[]{0,1,0,3,12};
            MoveZeroes(nums);
            foreach(var num in nums){
                Console.Write(num);
                Console.Write(" ");
            }
        }
    }
}
