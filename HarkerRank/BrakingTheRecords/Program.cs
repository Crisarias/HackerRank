using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrakingTheRecords
{
    class Program
    {
        public static int[] getRecord(int[] s)
        {
            // Complete this function
            if (s.Length == 0)
                return new int[] { 0, 0 };
            int[] results = new int[2];
            var min = s[0];
            var max = s[0];
            for (var i = 1; i < s.Length; i++) {
                if (s[i] > max) {
                    max = s[i];
                    results[0]++;
                }
                else if (s[i] < min) {
                    min = s[i];
                    results[1]++;
                }
            }
            return results;

        }

        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] s_temp = Console.ReadLine().Split(' ');
            int[] s = Array.ConvertAll(s_temp, Int32.Parse);
            int[] result = getRecord(s);
            Console.WriteLine(String.Join(" ", result));
        }
    }
}
