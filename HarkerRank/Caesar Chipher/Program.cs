using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Caesar_Chipher
{
    class Program
    {
/*\TEST
78
1X7T4VrCs23k4vv08D6yQ3S19G4rVP188M9ahuxB6j1tMGZs1m10ey7eUj62WV2exLT4C83zl7Q80M
27

1Y7U4WsDt23l4ww08E6zR3T19H4sWQ188N9bivyC6k1uNHAt1n10fz7fVk62XW2fyMU4D83am7R80N
*/

/*TEST2
90
!m-rB`-oN!.W`cLAcVbN/CqSoolII!SImji.!w/`Xu`uZa1TWPRq`uRBtok`xPT`lL-zPTc.BSRIhu..-!.!tcl!-U
62

!w-bL`-yX!.G`mVKmFlX/MaCyyvSS!CSwts.!g/`He`eJk1DGZBa`eBLdyu`hZD`vV-jZDm.LCBSre..-!.!dmv!-E
*/


        static string caesarCipher(string s, int k)
        {
            // Complete this function
            string result = string.Empty;
            var arr = s.ToArray();
            foreach (var c in arr)
            {
                if (c<=127 && (Regex.IsMatch(c.ToString(), "[A-Z]") || Regex.IsMatch(c.ToString(), "[a-z]")))
                {
                    var bas = Char.IsLower(c) ? 97 : 65;
                    var index = c - bas + k;
                    index = index % 26;
                    var newChar = Convert.ToChar(index + bas);
                    result += newChar.ToString();
                }
                else
                    result += c.ToString();
            }
            return result;
        }

        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string s = Console.ReadLine();
            int k = Convert.ToInt32(Console.ReadLine());
            string result = caesarCipher(s, k);
            Console.WriteLine(result);
        }
    }
}
