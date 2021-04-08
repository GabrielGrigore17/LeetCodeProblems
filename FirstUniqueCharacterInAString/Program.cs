using System;
using System.Collections.Generic;

namespace FirstUniqueCharacterInAString
{
    class Program
    {
        public static int FirstUniqChar(string s) {
            var set = new HashSet<char>();
            var uniq = new List<char>();
            for(int i = 0; i < s.Length; i++)
            {
                if(set.Add(s[i]))
                    uniq.Add(s[i]);
                else                    
                    if(uniq.Contains(s[i]))
                        uniq.Remove(s[i]);
            }
            if(uniq.Count == 0)
                return -1;
            else
                return s.IndexOf(uniq[0]);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(FirstUniqChar("loveleetcode"));
        }
    }
}
