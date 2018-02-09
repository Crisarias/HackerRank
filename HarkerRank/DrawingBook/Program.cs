using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingBook
{
    class Program
    {

        static int solve(int n, int p)
        {
            // Complete this function
            return p==1 || p == n || (n % 2 != 0 && p == n - 1) ? 0 : (n % 2 == 0 && p >= n - 2) ? 1 : p <= n / 2 ? p / 2 : (n - p) / 2;
        }

        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int p = Convert.ToInt32(Console.ReadLine());
            int result = solve(n, p);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
