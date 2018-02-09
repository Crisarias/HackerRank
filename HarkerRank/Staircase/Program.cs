using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staircase
{
    class Program
    {
        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
        }

        static void print(int n)
        {
            var str = new StringBuilder();
            for (var i = 1; i <= n; i++) {
                Console.WriteLine(str.Append(' ', n - i).Append('#',i));
                str.Clear();
            }
        }
    }
}
