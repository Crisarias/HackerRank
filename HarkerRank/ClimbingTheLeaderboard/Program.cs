using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClimbingTheLeaderboard
{
    class Program
    {
        static int[] climbingLeaderboard(int[] scores, int[] alice)
        {
            // Complete this function
            var results = new int[alice.Length];
            var scoresDistinct = scores.Distinct().ToList();
            var actualScore = 0;
            var lastIndex = -1;
            for (var i = 0; i < alice.Length;i++)
            {
                if (lastIndex > -1)
                    scoresDistinct.RemoveAt(lastIndex);
                actualScore = alice[i];
                var index = scoresDistinct.FindIndex(n => actualScore >= n);
                if (index == -1)
                {
                    scoresDistinct.Add(actualScore);
                    results[i] = scoresDistinct.Count();
                    lastIndex = results[i] -1;
                }
                else
                {
                    results[i] = index + 1;
                    if (actualScore > scoresDistinct[index])
                    {
                        scoresDistinct.Insert(index,actualScore);
                        lastIndex = index;
                    }
                    else
                    {
                        lastIndex = -1;
                    }                        
                }                   
            }            
            return results;
        }

        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] scores_temp = Console.ReadLine().Split(' ');
            int[] scores = Array.ConvertAll(scores_temp, Int32.Parse);
            int m = Convert.ToInt32(Console.ReadLine());
            string[] alice_temp = Console.ReadLine().Split(' ');
            int[] alice = Array.ConvertAll(alice_temp, Int32.Parse);
            int[] result = climbingLeaderboard(scores, alice);
            Console.WriteLine(String.Join("\n", result));


        }
    }
}
