using System;

namespace ReverseString
{
    class Program
    {
        public static void ReverseString(char[] s) {
            for(int i = 0; i < (s.Length - 1)/2; i++){
                var aux = s[i];
                s[i] = s[s.Length - 1 - i];
                s[s.Length - 1 - i] = aux;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
