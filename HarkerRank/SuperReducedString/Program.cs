using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperReducedString
{
    class Program
    {
        static string super_reduced_string(string s)
        {
            // Complete this function
            var res = QuitDuplicated(s.ToArray());
            return string.IsNullOrEmpty(res) ? "Empty String" : res;
        }

        static string QuitDuplicated(char[] words) {
            var result = string.Empty;
            for (var i = 0; i < words.Length; i++) {
                if(string.IsNullOrEmpty(result))
                    result += words[i];
                else if (result.Last() != words[i])
                    result += words[i];
                else
                    result = result.Substring(0, result.Length - 1);
            }
            return result;
        }

        static void Main(String[] args)
        {
            string s = Console.ReadLine();
            string result = super_reduced_string(s);
            Console.WriteLine(result);
        }
    }
}
