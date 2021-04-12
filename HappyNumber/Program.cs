using System;
using System.Collections.Generic;

namespace HappyNumber
{
    class Program
    {
        public static bool IsHappy(int n) {
            var isLoop = new HashSet<int>();
            while(n != 1){
                int nCopy = n;
                int nNew = 0;
                while(nCopy != 0){
                    nNew += (nCopy % 10) * (nCopy % 10);
                    nCopy /= 10; 
                }
                Console.WriteLine(nNew);
                if(!isLoop.Add(nNew))
                    return false;
                n = nNew;
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(IsHappy(19));
        }
    }
}
