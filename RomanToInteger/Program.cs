using System;
using System.Collections.Generic;

namespace RomanToInteger
{
    class Program
    {
        public static int RomanToInt(string s) {
            var dict = new Dictionary<char, int>();
            dict.Add('I', 1);
            dict.Add('V', 5);
            dict.Add('X', 10);
            dict.Add('L', 50);
            dict.Add('C', 100);
            dict.Add('D', 500);
            dict.Add('M', 1000);
            int output = 0;
            for(int i = 0; i < s.Length; i++)
            {
                if(i != s.Length - 1)
                    if(dict[s[i]] < dict[s[i+1]])
                    {
                        output += dict[s[i+1]] - dict[s[i]];
                        i++; 
                    }
                    else
                        output += dict[s[i]];
                else
                    output += dict[s[i]];
            }
            return output;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(RomanToInt("MCMXCIV"));
        }
    }
}
