using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_Conversion
{
    class Program
    {
        static string timeConversion(string s)
        {
            // Complete this function
            return DateTime.Parse(s).ToString("HH:mm:ss");
        }

        static void Main(String[] args)
        {
            string s = Console.ReadLine();
            string result = timeConversion(s);
            Console.WriteLine(result);
        }
    }
}
