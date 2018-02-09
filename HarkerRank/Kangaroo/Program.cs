using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kangaroo
{
    class Program
    {
        static string kangaroo(int x1, int v1, int x2, int v2)
        {
            // Complete this function
            int loopCounter = 0;
            while (loopCounter < 10000 && (x1 + v1) != (x2 + v2))
            {
                x1 = x1 + v1;
                x2 = x2 + v2;
                loopCounter++;
            }
            return loopCounter < 10000 ? "YES" : "NO";
        }

        static void Main(String[] args)
        {
            string[] tokens_x1 = Console.ReadLine().Split(' ');
            int x1 = Convert.ToInt32(tokens_x1[0]);
            int v1 = Convert.ToInt32(tokens_x1[1]);
            int x2 = Convert.ToInt32(tokens_x1[2]);
            int v2 = Convert.ToInt32(tokens_x1[3]);
            string result = kangaroo(x1, v1, x2, v2);
            Console.WriteLine(result);
        }
    }
}
