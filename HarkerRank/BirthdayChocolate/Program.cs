using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayChocolate
{
    class Program
    {
        public static int solve(int n, int[] s, int d, int m)
        {
            // Complete this function
            if (s.Length == 0)
                return 0;
            var result = 0;
            for (var i=0; i < s.Length; i++) {
                if ((i + m - 1) >= s.Length)
                    break;
                if (s.Skip(i).Take(m).Sum() == d)
                    result++;
            }            
            return result;
        }

        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] s_temp = Console.ReadLine().Split(' ');
            int[] s = Array.ConvertAll(s_temp, Int32.Parse);
            string[] tokens_d = Console.ReadLine().Split(' ');
            int d = Convert.ToInt32(tokens_d[0]);
            int m = Convert.ToInt32(tokens_d[1]);
            int result = solve(n, s, d, m);
            Console.WriteLine(result);
        }
    }
}
