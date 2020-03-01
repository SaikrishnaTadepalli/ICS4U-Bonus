/*****************************************************************
    PROGRAMME	:	BONUS Advances Palindrome

    OUTLINE		:	This program asks the user to input a string
                    and checks wether the alphanumeric characters
                    within the string form a palindrome, that is, 
                    a string that is the same in both directions.

    PROGRAMMER	:	Saikrishna Tadepalli

    DATE		:   January 6th 2020
*****************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace TadepalliS_BONUSAdvancedPalindorme
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                GetInput();
                Console.Write("\nTest another Palindrome (y/n)?: ");

                if (Console.ReadLine().ToString().ToUpper() != "Y")
                    break;
                else
                    Console.WriteLine("\n- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -\n");

            } while (true);
        }

        static void GetInput()
        {
            Console.Write("Enter a Potential Palindrome: ");
            
            string input = GetCompressed(Console.ReadLine());

            if (IsPalindrome(input))
                Console.WriteLine("String IS a palindrome.");
            else
                Console.WriteLine("String is NOT a palindrome!");            
        }

        static string GetCompressed(string inpStr)
        {
            inpStr = Regex.Replace(inpStr, @"s", "");
            inpStr = Regex.Replace(inpStr, "[^a-zA-Z0-9]+", "", RegexOptions.Compiled);
            inpStr = inpStr.ToUpper();

            Console.WriteLine("\nCompressed String: " + inpStr + "\n");
            return inpStr;
        }

        static bool IsPalindrome(string inpStr)
        {
            string reverseStr = ReverseString(inpStr);

            for (int i = 0; i < inpStr.Length; i++)
                if (inpStr[i] != reverseStr[i])
                    return false;

            return true;
        }

        static string ReverseString(string inpStr)
        {
            char[] charArray = inpStr.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
