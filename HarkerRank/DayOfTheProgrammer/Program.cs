using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOfTheProgrammer
{
    class Program
    {

        static string solve(int year)
        {
            // Complete this function
            if (year <= 1917)
            {
                return isJulianLeapYear(year) ? new DateTime(year, 9, 12).ToString("dd.MM.yyyy") : new DateTime(year, 9, 13).ToString("dd.MM.yyyy");
            }
            else if (year == 1918)
            {
                return new DateTime(year, 8, 26).ToString("dd.MM.yyyy");
            }
            else 
            {
                return isGregorianLeapYear(year) ? new DateTime(year, 9, 12).ToString("dd.MM.yyyy") : new DateTime(year, 9, 13).ToString("dd.MM.yyyy");
            }
        }

        static bool isGregorianLeapYear(int year) {
            return year % 400 == 0 || (year % 4 == 0 && year % 100 != 0);
        }

        static bool isJulianLeapYear(int year)
        {
            return year % 4 == 0;
        }

        static void Main(String[] args)
        {
            int year = Convert.ToInt32(Console.ReadLine());
            string result = solve(year);
            Console.WriteLine(result);
        }
    }
}
