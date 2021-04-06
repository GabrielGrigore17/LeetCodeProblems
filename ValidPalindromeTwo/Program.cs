using System;

namespace ValidPalindromeTwo
{
    class Program
    {
        public static bool ValidPalindrome(string s) {
        bool oneChar = false;
        int i = 0;
        int j = s.Length - 1;
        int condition = s.Length % 2 == 0 ? s.Length + 1 : s.Length;
        while(i < j)
        {
            Console.Write(s[i]);
            Console.Write(s[j]);
            Console.Write(" ");

            if(s[i] == s[j]){
                i++;
                j--;
                continue;
            }
            if(oneChar)
                return false;
            else
                if(s[i+1] == s[j] && s[i] == s[j-1] && oneChar){
                    bool left = ValidPalindrome(s.Substring(i+1, j));
                    bool right = ValidPalindrome(s.Substring(i, j-1));
                    if(left || right)
                        return true;
                    else 
                        return false;
                }
                else
                    if(s[i+1] == s[j]){
                        i++;
                        oneChar = true;
                        continue;
                    }
                    else
                        if(s[i] == s[j-1]){
                            j--;
                            oneChar = true;
                            continue;
                        }
                        else
                            return false;
        }
        return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("test");
            Console.WriteLine(ValidPalindrome("ebcbbececabbacecbbcbe"));
        }
    }
}
