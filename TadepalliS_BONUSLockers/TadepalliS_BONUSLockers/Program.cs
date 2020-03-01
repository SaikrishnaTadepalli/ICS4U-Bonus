/*****************************************************************
    PROGRAMME	:	BONUS Lockers

    OUTLINE		:	This program asks the user to input the number
                    of lockers and students in a school, and it
                    outputs the number of lockers opened at the end
                    if every nth students flips the open/closed state 
                    of every nth locker.

    PROGRAMMER	:	Saikrishna Tadepalli

    DATE		:   January 6th 2020
*****************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace TadepalliS_BONUSLockers
{
    class Program
    {
        static void Main(string[] args)
        {
            int lockers;
            int students;
            string fileOut = "";
            StreamWriter sr = File.CreateText("lockers.txt");

            Console.Write("Enter the number of lockers at your school : ");
            lockers = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of students at your school : ");
            students = int.Parse(Console.ReadLine());

            List<int> openLockers = Flip(lockers, students);

            fileOut = string.Join(",", openLockers);
            fileOut = Regex.Replace(fileOut, "(.{" + 50 + "})", "$1" + Environment.NewLine); ;

            sr.WriteLine("Number of Lockers: " + lockers);
            sr.WriteLine("Number of Students: " + students);
            sr.WriteLine("");

            sr.WriteLine("Open Locker's Numbers:");
            sr.WriteLine("");
            sr.Write(fileOut);
            
            sr.Close();
            Console.WriteLine("Data was Outputted to file.");

            Console.WriteLine("\n\n\n" + fileOut);

            Console.ReadKey();
        }

        static List<int> Flip(int objectCount, int flipperCount)
        {
            int o = objectCount;
            int f = flipperCount;
            
            List<int> lstOut = new List<int>();

            for (int i = 1; i <= o; i++)
            {
                List<int> factorsList = new List<int>();

                for (int j = 1; j <= f; j++)
                    if (i%j==0)
                        factorsList.Add(j);


                if (factorsList.ToArray().Length % 2 == 1)
                    lstOut.Add(i);
            }

            return lstOut;
        }
    }
}
