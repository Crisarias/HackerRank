using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisibleNumPairs
{
    class Program
    {

        public static int divisibleSumPairs(int n, int k, int[] ar)
        {            
            int result = 0;
            for (var i = 0; i < n; i++)
                result += ar.Skip(i+1).Count(x => (x + ar[i]) % k == 0);
            return result;
        }

        static void Main(String[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] ar_temp = Console.ReadLine().Split(' ');
            int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
            int result = divisibleSumPairs(n, k, ar);
            Console.WriteLine(result);
        }
    }
}
