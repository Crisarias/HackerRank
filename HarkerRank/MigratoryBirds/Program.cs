using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigratoryBirds
{
    class Program
    {

        static int migratoryBirds(int n, int[] ar)
        {
            // Complete this function
            Dictionary<int, int> types = new Dictionary<int, int>();
            types.Add(1, 0);
            types.Add(2, 0);
            types.Add(3, 0);
            types.Add(4, 0);
            types.Add(5, 0);
            for(var i=0;i<n;i++) {
                var value = types[ar[i]] + 1;
                types[ar[i]] = value;
            }
            var max = types.Max(x => x.Value);
            return types.Where(x => x.Value == max).First().Key;
        }

        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] ar_temp = Console.ReadLine().Split(' ');
            int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
            int result = migratoryBirds(n, ar);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
