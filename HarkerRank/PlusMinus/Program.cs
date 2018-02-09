using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlusMinus
{
    class Program
    {
        static void Main(String[] args)
        {
            decimal n = Decimal.Parse(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            Algorithm(n, arr);
        }

        static void Algorithm(decimal n, int[] a)
        {
            var arr = new int[3];
            GetNumbers(arr, a);
            var results = new decimal[3];
            results[0] = arr[0] / n;
            results[1] = arr[1] / n;
            results[2] = arr[2] / n;
            Console.WriteLine(results[0]);
            Console.WriteLine(results[1]);
            Console.WriteLine(results[2]);

        }

        static void GetNumbers(int[] arr, int[] a)
        {
            for (var i = 0; i < a.Length; i++)
            {
                if (a[i] == 0)
                    arr[2]++;
                else if (a[i] > 0)
                    arr[0]++;
                else
                    arr[1]++;
            }
        }
    }
}
