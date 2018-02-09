using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMaxSum
{
    class Program
    {
        static void Main(String[] args)
        {
            string[] arr_temp = Console.ReadLine().Split(' ');
            long[] arr = Array.ConvertAll(arr_temp, long.Parse);
            suma(arr);
        }

        static void suma(long[] arr)
        {
            long min = (long)arr[0], max = (long)arr[0], sum = (long)arr[0];
            for (var i = 1; i < arr.Length; i++)
            {
                sum += (long)arr[i];
                if (arr[i] < min) min = (long)arr[i];
                if (arr[i] > max) max = (long)arr[i];
            }
            Console.WriteLine((sum - max) + " " + (sum - min));
        }        
    }
}
