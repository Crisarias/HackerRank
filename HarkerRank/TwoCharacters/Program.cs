using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TwoCharacters
{
    class Program
    {

        static int twoCharaters(string s)
        {
            // Complete this function
            var letters = s.ToArray().Distinct();
            var res = Process(letters, s);
            return res;
        }

        static int Process(IEnumerable<char> letters,string str) {
            var combinations = new List<int>();
            for (var i = 0; i < letters.Count(); i++) {
                for (var j = i + 1; j < letters.Count(); j++) {
                    var result = str;
                    var remove = letters.Where(c => c != letters.ElementAt(i) && c != letters.ElementAt(j));
                    for (var k = 0; k < remove.Count(); k++)
                    {
                        result = result.Replace(remove.ElementAt(k).ToString(), "");
                    }
                    if (!(Regex.IsMatch(result, letters.ElementAt(i).ToString() + letters.ElementAt(i).ToString() + "+") ||
                        Regex.IsMatch(result, letters.ElementAt(j).ToString() + letters.ElementAt(j).ToString() + "+")))
                        combinations.Add(result.Length);
                }
            }
            return combinations.Count>0 ? combinations.Max() : 0;
        }
        

        static void Main(String[] args)
        {
            int l = Convert.ToInt32(Console.ReadLine());
            string s = Console.ReadLine();
            int result = twoCharaters(s);
            Console.WriteLine(result);
        }
    }
}
