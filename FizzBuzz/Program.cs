using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    class Program
    {
        public static IList<string> FizzBuzz(int n) {
            var output = new string[n];
            for(int i = 1; i <= n; i++)
            {
                if(i % 15 == 0){
                    output[i-1] = "FizzBuzz";
                    continue;
                }
                if(i % 3 == 0)
                {
                    output[i-1] = "Fizz";
                    continue;
                }
                if(i % 5 == 0)
                {
                    output[i-1] = "Buzz";
                    continue;
                }
                output[i-1] = i.ToString();
            }
            return output;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
