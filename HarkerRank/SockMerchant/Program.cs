using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SockMerchant
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    class Solution
    {

        static int sockMerchant(int n, int[] ar)
        {
            var pairs = 0;
            var processed = new int[ar.Length];
            var cont = 0;
            for (var i = 0; i < ar.Length; i++) {
                if (processed.Contains(ar[i])) {
                    continue;
                }  
                else {
                    processed[cont] = ar[i];
                    cont++;
                }
                pairs += ar.Count(x => x.Equals(ar[i])) / 2;                
            }
            // Complete this function
            return pairs;
        }

        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] ar_temp = Console.ReadLine().Split(' ');
            int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
            int result = sockMerchant(n, ar);
            Console.WriteLine(result);
        }
    }
}
