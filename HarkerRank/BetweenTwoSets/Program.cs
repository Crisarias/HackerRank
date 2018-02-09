using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetweenTwoSets
{
    class Program
    {

        static int getTotalX(int[] a, int[] b)
        {
            // Complete this function
            int f = lcm(a);
            int l = gcd(b);
            int count = 0;
            for (int i = f, j = 2; i <= l; i = f * j, j++)
            {
                if (l % i == 0) { count++; }
            }
            return count;
        }

        private static int gcd(int a, int b)
        {
            while (b > 0)
            {
                int temp = b;
                b = a % b; // % is remainder
                a = temp;
            }
            return a;
        }

        private static int gcd(int[] input)
        {
            int result = input[0];
            for (int i = 1; i < input.Length; i++)
            {
                result = gcd(result, input[i]);
            }
            return result;
        }

        private static int lcm(int a, int b)
        {
            return a * b / gcd(a, b);
        }

        private static int lcm(int[] input)
        {
            int result = input[0];
            for (int i = 1; i < input.Length; i++)
            {
                result = lcm(result, input[i]);
            }
            return result;
        }

        static void Main(String[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int m = Convert.ToInt32(tokens_n[1]);
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);
            string[] b_temp = Console.ReadLine().Split(' ');
            int[] b = Array.ConvertAll(b_temp, Int32.Parse);
            int total = getTotalX(a, b);
            Console.WriteLine(total);
        }
    }
}
