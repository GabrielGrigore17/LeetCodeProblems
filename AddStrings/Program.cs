using System;
using System.Collections.Generic;

namespace AddStrings
{
    class Program
    {
        public static string AddStrings(string num1, string num2) {
            // List<char> sum = new List<char>();
            var sum = "";
            var reverseMax = "";
            var reverseMin = "";
            if(num1.Length > num2.Length)
            {
                reverseMax = ReverseString(num1);
                reverseMin = ReverseString(num2);
            }
            else
            {
                reverseMin = ReverseString(num1);
                reverseMax = ReverseString(num2);
            }

            var difference = num1.Length - num2.Length;
            bool buffer = false;
            int current = 0;

            for (int i = 0; i < reverseMax.Length; i++)
            {
                if(i < reverseMin.Length){
                    current = reverseMin[i] + reverseMax[i] - 48 * 2;
                    if(buffer){
                        current += 1;
                        buffer = false;
                    }
                    if(current > 9)
                        buffer = true;
                    sum = current % 10 + sum;
                }
                else
                {
                    current = reverseMax[i] - 48;
                    if(buffer){
                        current += 1;
                        buffer = false;
                    }
                    if(current > 9)
                        buffer = true;
                    sum = current % 10 + sum;
                }
            }
            if(buffer)
                sum = "1" + sum;
            return sum;
        }

        public static string ReverseString (string number) {
            var length = number.Length - 1;
            var reverse = "";
            while(length >= 0)
            {
                reverse = reverse + number[length];
                length--;
            }
            return reverse;

        }
        static void Main(string[] args)
        {
            Console.WriteLine(AddStrings("99", "9"));
        }
    }
}
