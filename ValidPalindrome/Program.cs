using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace ValidPalindrome
{
    class Program
    {
        public static bool IsPalindrome(string s) {
            var str = FormatString(s);
            for(int i = 0; i < str.Length/2; i++){
                if(str[i] != str[str.Length - i - 1])
                    return false;
            }
            return true;

        }
        public static string FormatString(string str){
            char[] arr = str.Where(c => (char.IsLetterOrDigit(c))).ToArray(); 
            str = (new string(arr)).ToLower();
            return str;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(FormatString("A man, a plan, a canal: Panama"));
            Console.WriteLine(IsPalindrome("A man, a plan, a canal: Panama"));
        }
    }
}
