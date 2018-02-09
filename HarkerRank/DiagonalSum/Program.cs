using System;

namespace DiagonalSum
{
    class Program
    {
        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[][] a = new int[n][];
            for (int a_i = 0; a_i < n; a_i++)
            {
                string[] a_temp = Console.ReadLine().Split(' ');
                a[a_i] = Array.ConvertAll(a_temp, Int32.Parse);
            }
            var difference = DiagonalDifference(n, a);
            Console.WriteLine(difference);
        }

        static int DiagonalDifference(int n, int[][] a)
        {
            var result = FirstDiagonal(a) - SecondDiagonal(a);
            return result = result >= 0 ? result : result * -1;
        }

        static int FirstDiagonal(int[][] a)
        {
            var result = 0;
            for (var i = 0; i < a.GetLength(0); i++)
            {
                if (a[i].Length - 1 < i)
                    break;
                result += a[i][i];
            }
            return result;
        }

        static int SecondDiagonal(int[][] a)
        {
            var result = 0;
            var columnCont = 0;
            for (var i = a.GetLength(0) - 1; i >= 0; i--)
            {
                if (a[i].Length - 1 < columnCont)
                    break;
                result += a[i][columnCont];
                columnCont++;
            }
            return result;
        }
    }
}
