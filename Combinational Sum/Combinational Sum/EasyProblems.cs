using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combinational_Sum
{
    public static class EasyProblems
    {
        //[Minimum Product of k Integers]
        public static void Solution1(int[] array,int k)
        {
            Array.Sort(array);
            long res = 1;
            for (var i = 0; i < k; i++) {
                res = res * array[i];
            }
            Console.WriteLine();
            Console.WriteLine($"Minimum Product of {k} Integers from {string.Join(",",array)}");
            Console.WriteLine(res);
        }
    }
}
