using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingValleys
{
    class Program
    {
        static void Main(String[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            var steps = Convert.ToInt32(Console.ReadLine());
            var arr = Console.ReadLine().ToString().ToCharArray();
            Console.WriteLine(ValleysHiked(arr));
        }

        private static int ValleysHiked(char[] arr)
        {
            var level = 0;
            var valleys = 0;
            for (var i = 0; i < arr.Length; i++) {
                var ceroLevel = level == 0;
                level = arr[i].Equals('U') ?  level+1 : level-1;
                if (level == -1 && ceroLevel)
                    valleys++;
            }
            return valleys;
        }
    }
}
