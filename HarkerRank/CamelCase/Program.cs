using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamelCase
{
    class Program
    {
        static int camelcase(string s)
        {
            // Complete this function
            var arr = s.ToArray();
            if (Char.IsLower(arr[0]))
                return arr.Count(w => Char.IsUpper(w)) + 1;
            else
                return arr.Count(w => Char.IsUpper(w));
        }

        static void Main(String[] args)
        {
            string s = Console.ReadLine();
            int result = camelcase(s);
            Console.WriteLine(result);
        }
    }
}
