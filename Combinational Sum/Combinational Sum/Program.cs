using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combinational_Sum
{
    class Program
    {
        private static int[] arr= new int[]{1,2,3};

        static void Main(string[] args)
        {
            EasyProblems.Solution1(new int[] {198,76,544,123,154,675}, 2);
            EasyProblems.Solution1(new int[] { 11,8,5,7,5,100}, 4);
            EasyProblems.Solution1(new int[] { 362,344,113,100,337,410,274,5 }, 0);
            EasyProblems.Solution1(new int[] { 168, 372, 141, 96, 439, 187, 144, 42, 425, 286, 272, 87, 421, 311, 49, 341, 282, 255, 52, 363, 425, 350 }, 8);
            Combinations();
            Console.ReadLine();
            
        }


        #region recursion

        private static void Combinations() {
            Console.WriteLine();
            Console.WriteLine("Letters Combination of ABCD");
            string[] combinations = LettersCombination.Combination2("ABCD");
            foreach (string str in combinations)
            {
                Console.WriteLine(str);
            }
            IList<IList<int>> combinationSums = CombinationSumAlgorithm.CombinationSum(arr, 8);
            Console.WriteLine();
            Console.WriteLine("Sum Combination of 1,2,3 for 3");
            foreach (List<int> combination in combinationSums)
            {
                Console.WriteLine(string.Join(",", combination));
            }
           
        }

        #endregion


    }
}
