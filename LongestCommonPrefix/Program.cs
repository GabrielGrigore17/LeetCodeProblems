using System;

namespace LongestCommonPrefix
{
    class Program
    {
        public static string LongestCommonPrefix(string[] strs) {
            if(strs.Length == 0)
                return "";
            string prefix = "";
            string tryPrefix = "";
            for(int i = 0; i < strs[0].Length; i++){     
                tryPrefix = tryPrefix + strs[0][i];       
                for(int j = 0; j < strs.Length; j++){
                    if(!strs[j].StartsWith(tryPrefix))
                        return prefix;
                }
                prefix = tryPrefix;
            }
            return prefix;
        }
        static void Main(string[] args)
        {
            var strs = new string[] {"dog","racecar","car"};
            Console.WriteLine(LongestCommonPrefix(strs));
        }
    }
}
