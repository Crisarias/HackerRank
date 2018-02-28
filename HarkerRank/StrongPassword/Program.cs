using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StrongPassword
{
    class Program
    {
        static int minimumNumber(int n, string password)
        {
            // Return the minimum number of characters to make the password strong
            var cont = 0;
            var numbers = "[0123456789]";
            var lower_case = "[abcdefghijklmnopqrstuvwxyz]";
            var upper_case = "[ABCDEFGHIJKLMNOPQRSTUVWXYZ]";
            var special_characters = "[!@#$%^&*()+-]";
            if (!Regex.Match(password, numbers).Success)
                cont++;
            if (!Regex.Match(password, lower_case).Success)
                cont++;
            if (!Regex.Match(password, upper_case).Success)
                cont++;
            if (!Regex.Match(password,special_characters).Success)
                cont++;
            return password.Length < 6 && (6 - password.Length) > cont ? (6 - password.Length) : cont;
        }

        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string password = Console.ReadLine();
            int answer = minimumNumber(n, password);
            Console.WriteLine(answer);
        }
    }
}
