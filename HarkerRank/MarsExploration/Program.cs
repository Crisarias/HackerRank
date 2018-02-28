using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsExploration
{
    class Program
    {
        static int marsExploration(string s)
        {
            // Complete this function
            var arr = s.Select(c=>c.ToString());
            var altered = 0;
            var cont = 1;
            for (var i = 0; i < arr.Count(); i++) {
                if ((cont == 1 || cont == 3) && arr.ElementAt(i) != "S")
                    altered++;
                else if(cont ==2 && arr.ElementAt(i) != "O")
                    altered++;
                if (cont == 3)
                    cont = 1;
                else
                    cont++;
            }
            return altered;
        }

        static void Main(String[] args)
        {
            string s = Console.ReadLine();
            int result = marsExploration(s);
            Console.WriteLine(result);
        }
    }
}
