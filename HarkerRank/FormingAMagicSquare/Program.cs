using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormingAMagicSquare
{
    class Program
    {
        static List<int[,]> combinations = new List<int[,]>(8);

        static int formingMagicSquare(int[][] s)
        {
            // Complete this function
            FillCombinations();
            //printCombinations();
            var costs = new List<int>(8);
            foreach (var c in combinations)
            {
                var cost = 0;
                for (var i = 0; i < 3; i++)
                {
                    for (var j = 0; j < 3; j++)
                    {
                        cost += Math.Abs(c[i, j] - s[i][j]);
                    }
                }
                costs.Add(cost);
            }
            return costs.Min();
        }

        static void Main(String[] args)
        {
            int[][] s = new int[3][];
            for (int s_i = 0; s_i < 3; s_i++)
            {
                string[] s_temp = Console.ReadLine().Split(' ');
                s[s_i] = Array.ConvertAll(s_temp, Int32.Parse);
            }
            int result = formingMagicSquare(s);
            Console.WriteLine(result);
        }

        static void FillCombinations()
        {
            combinations = new List<int[,]>(8);
            var pairs = new int[] { 2, 4, 6, 8 };
            var Index1 = new List<int>(4);
            var Index2 = new List<int>(4);
            while (combinations.Count < 8)
            {
                var c = new int[3, 3];
                if (Index1.Count < 4)
                {
                    c[0, 0] = pairs.First(x => !Index1.Contains(x));
                    Index1.Add(c[0, 0]);
                    c[0, 2] = c[0, 0] < 5 ? c[0, 0] + 4 : c[0, 0] - 4;
                    calculateOthers(ref c);
                }
                else
                {
                    c[0, 2] = pairs.First(x => !Index2.Contains(x));
                    Index2.Add(c[0, 2]);
                    c[0, 0] = c[0, 2] == 2  || c[0, 2] == 6  ? c[0, 2] + 2 : c[0, 2] - 2;
                    calculateOthers(ref c);
                }
                combinations.Add(c);
            }
        }

        static void calculateOthers(ref int[,] c)
        {
            c[0, 1] = 15 - c[0, 0] - c[0, 2];
            c[2, 0] = 10 - c[0, 2];
            c[2, 2] = 10 - c[0, 0];
            c[2, 1] = 15 - c[2, 0] - c[2, 2];
            c[1, 1] = 5;
            c[1, 0] = 15 - c[0, 0] - c[2, 0];
            c[1, 2] = 15 - c[0, 2] - c[2, 2];
        }

        static void printCombinations()
        {
            foreach (var c in combinations)
            {
                Console.WriteLine(c[0, 0] + " " + c[0, 1] + " " + c[0, 2]);
                Console.WriteLine(c[1, 0] + " " + c[1, 1] + " " + c[1, 2]);
                Console.WriteLine(c[2, 0] + " " + c[2, 1] + " " + c[2, 2]);
                Console.WriteLine();
            }
        }
    }
}

