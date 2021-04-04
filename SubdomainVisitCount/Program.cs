using System;
using System.Collections.Generic;
using System.Text;

namespace SubdomainVisitCount
{
    class Program
    {
        public static IList<string> SubdomainVisits(string[] cpdomains) {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            List<string> output = new List<string>();
            for(int i = 0; i < cpdomains.Length; i++)
            {
                string[] subs = cpdomains[i].Split(' ');
                if(dict.ContainsKey(subs[1])){
                    dict[subs[1]] += int.Parse(subs[0]);
                }
                else{
                    dict[subs[1]] = int.Parse(subs[0]);
                }
                var sub1 = subs[1].Remove(0, subs[1].IndexOf('.') + 1);
                var sub2 = subs[1].Remove(0, subs[1].LastIndexOf('.') + 1);
                if(sub1 == sub2){
                    if(dict.ContainsKey(sub1))  
                        dict[sub1] += int.Parse(subs[0]);
                    else
                        dict[sub1] = int.Parse(subs[0]);
                }
                else{
                    if(dict.ContainsKey(sub1))  
                        dict[sub1] += int.Parse(subs[0]);
                    else
                        dict[sub1] = int.Parse(subs[0]);
                    if(dict.ContainsKey(sub2))  
                        dict[sub2] += int.Parse(subs[0]);
                    else
                        dict[sub2] = int.Parse(subs[0]);
                }
            }
            foreach(var entry in dict){
                StringBuilder str = new StringBuilder();
                str.Append(entry.Value.ToString());
                str.Append(" ");
                str.Append(entry.Key);
                output.Add(str.ToString());
            }
            return output;
        }
        static void Main(string[] args)
        {
            var example = new string[] {"900 google.mail.com", "50 yahoo.com", "1 intel.mail.com", "5 wiki.org"};
            List<string> list = (List<string>)SubdomainVisits(example);
            foreach(var entry in list)
                Console.WriteLine(entry);
        }
    }
}
