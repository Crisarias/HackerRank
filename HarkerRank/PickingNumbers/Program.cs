using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickingNumbers
{
    class Program
    {
        static int pickingNumbers(int[] a)
        {
            var orderList = a.OrderBy(n=>n);
            var counts = new List<int>();
            var count = 0;
            var lastStart = 0;
            for (var i = 0; i < orderList.Count()-1; i++) {
                if (Math.Abs(orderList.ElementAt(i + 1) - orderList.ElementAt(lastStart)) <= 1)
                {
                    count++;
                }
                else
                {
                    if(count > 0)
                        counts.Add(count+1);
                    lastStart = i+1;
                    count = 0;
                }
            }
            if (count > 0)
                counts.Add(count + 1);
            return counts.Max();
        }

        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);
            int result = pickingNumbers(a);
            Console.WriteLine(result);
        }
    }
}
