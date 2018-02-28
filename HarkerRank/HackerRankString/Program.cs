using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankString
{
    class Program
    {
        static string hackerrankInString(string s)
        {
            // Complete this function
            var arr = "hackerrank".ToArray();
            var cont = 0;
            foreach (var c in s.ToArray())
            {
                if (arr[cont] == c)
                    cont++;
                if (cont + 1 == arr.Length)
                    break;
            }
            return cont + 1 == arr.Length ? "YES" : "NO";
        }

        static void Main(String[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < q; a0++)
            {
                string s = Console.ReadLine();
                string result = hackerrankInString(s);
                Console.WriteLine(result);
            }
        }
    }
}
