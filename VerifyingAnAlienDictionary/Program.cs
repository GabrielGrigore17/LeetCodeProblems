using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VerifyingAnAlienDictionary
{
    class Program
    {
        public static bool IsAlienSorted(string[] words, string order) {
            var orderCorrect = "abcdefghijklmnopqrstuvwxyz";
            var hmap = new Dictionary<char, char>();
            var N = words.Length;
            var wordsClone = new string[N];

            for(int i = 0; i < order.Length; ++i)
                hmap.Add(order[i], orderCorrect[i]);

            Array.Copy(words, wordsClone, N);
            Array.Sort(wordsClone, (x,y) => {
                var sbX = new StringBuilder();
                var sbY = new StringBuilder();

                foreach(var c in x) sbX.Append(hmap[c]);
                foreach(var c in y) sbY.Append(hmap[c]);

                return sbX.ToString().CompareTo(sbY.ToString());
            });

            return words.SequenceEqual(wordsClone);
        }
    

        static void Main(string[] args)
        {
            Console.WriteLine(IsAlienSorted(new string[]{"word","world","row"}, "worldabcefghijkmnpqstuvxyz"));
        }
    }
}
