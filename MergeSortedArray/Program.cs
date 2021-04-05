using System;

namespace MergeSortedArray
{
    class Program
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n) 
        {
            for(int i = m; i < n + m; i++)
            {
                nums1[i] = nums2[i-m];
            }
            Array.Sort(nums1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
