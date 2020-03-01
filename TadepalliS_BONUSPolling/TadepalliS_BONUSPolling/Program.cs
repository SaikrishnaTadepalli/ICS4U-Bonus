/*****************************************************************
    PROGRAMME	:	BONUS Polling

    OUTLINE		:	This program asks the user to rate on a scale
                    of 1-10 the importance of 5 different topics.
                    The user is able to enter as much data as they
                    want, that is to say, as many people as necesairy
                    are able to be polled, and their data is compiled
                    and processed by the progrm. Once all the polling
                    is finished, the program outputs a graph that shows
                    the number of polls in terms of importance per
                    topic, and it shows the data's most popular and
                    least popular choices in terms of importance.

    PROGRAMMER	:	Saikrishna Tadepalli

    DATE		:   January 6th 2020
*****************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TadepalliS_BONUSPolling
{
    class Program
    {
        static int[,] ratings = new int[5,10];
        static int dataCount = 0;
        static void Main(string[] args)
        {
            AskQuestions();

            while (true)
            {
                Console.WriteLine("");
                Console.Write("Enter more data? (y/n) - ");

                if (Console.ReadLine().ToString().ToUpper() == "Y")
                    AskQuestions();
                else
                    break;
            }

            DisplayData();

            Console.ReadKey();
        }

        static void AskQuestions()
        {
            string[] topic = ("Global Warming*The Economy*War*Health Care*Education").Split(Convert.ToChar("*"));

            for (int i = 0; i < topic.Length; i++)
            {
                int rate = 0;
                Console.Write("On a scale on 1 to 10, how important is " + topic[i] + "?\n\t> ");

                while (true)
                {
                    if (int.TryParse(Console.ReadLine().ToString(), out rate))
                        if (1<= rate && 10 >= rate)
                            break;

                    Console.Write("\t(Enter a number from 1-10)\n\t> ");
                }

                ratings[i,rate-1] += 1;
                Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - -\n");
            }

            dataCount += 1;
        }

        static void DisplayData()
        {
            string[] topic = ("Global Warming*The Economy*War*Health Care*Education").Split(Convert.ToChar("*"));

            Console.WriteLine("\n\n_______________________________________________________________________________________________________________\n\n");
            Console.WriteLine("Topic".PadRight("Global Warming".Length, Convert.ToChar(" ")) +"\t|\t1\t2\t3\t4\t5\t6\t7\t8\t9\t10\tAverage");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------");

            for (int i = 0; i < topic.Length; i++)
            {
                string rates = "";
                double average = 0;

                for (int j = 0; j < 10; j++)
                {
                    rates += ratings[i, j].ToString() + "\t";
                    average += double.Parse(ratings[i, j].ToString())*(j+1);
                }

                average /= dataCount;
                Console.WriteLine(topic[i].PadRight("Global Warming".Length, Convert.ToChar(" ")) + "\t|\t" + rates + string.Format("{0:F1}", average));
            }

            int maxIndex = 0;
            int minIndex = 0;
            int max = 0;
            int min = 0;

            for (int i = 0; i < 5; i++)
            {
                int num = 0;

                for (int j = 0; j < 10; j++)
                    num += ratings[i, j]*(j+1);    

                if (num > max)
                {
                    max = num;
                    maxIndex = i;
                }

                if (i == 0)
                {
                    minIndex = 0;
                    min = num;
                }
            }

            Console.WriteLine("\n\nHighest Points: " + topic[maxIndex] + " (" + max +")\n");
            Console.WriteLine("Lowest Points: " + topic[minIndex] + " (" + min + ")");
        }
    }
}
