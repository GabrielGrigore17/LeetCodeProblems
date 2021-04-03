using System;
using System.Collections.Generic;

namespace VerifyingAnAlienDictionary
{
    class Program
    {
        public static bool IsAlienSorted(string[] words, string order) {
        
        for(int i = 0; i<words.Length-1; i++){
            
            var first = words[i];
            var second = words[i+1];
            
            if(!Compare(first, second, order)){
                return false;
            }
        }
        return true;
        }
        public static bool Compare(string first, string second, string order){
        
            for(int i = 0; i< Math.Min(first.Length, second.Length); i++){
                
                if(order.IndexOf(first[i]) == order.IndexOf(second[i]) ){
                    continue;
                }else if(order.IndexOf(first[i]) < order.IndexOf(second[i]) ){
                    return true;
                }else{
                    return false;
                }
            }
            return first.Length < second.Length;
        }
    

        static void Main(string[] args)
        {
            Console.WriteLine(IsAlienSorted(new string[]{"word","world","row"}, "worldabcefghijkmnpqstuvxyz"));
        }
    }
}
