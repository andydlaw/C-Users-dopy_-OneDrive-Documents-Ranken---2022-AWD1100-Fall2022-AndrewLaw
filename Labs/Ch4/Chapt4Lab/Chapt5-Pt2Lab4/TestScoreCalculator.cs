using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

/*
 * LB4. Write a console application that accepts an indefinite number of test scores for a student, and then computes some statistics about those scores:
●	Prompt the user for test scores until they enter 999
●	If the user enters a score inside the range of 0 through 100
    ○	Accept the score
    ○	Prompt the user for another score
●	If the user enters 999
    ○	Ignore the test score
    ○	Do not display an error message
    ○	display the number of scores, sum, average, min, and max
    ○	stop the program
●	If they enter a score outside the range of 0 through 100
    ○	Ignore the test score
    ○	Display an error message
    ○	Prompt the user for another score

*/

namespace Chapt5_Pt2Lab4
{
    internal class TestScoreCalculator
    {
        const int MINSCORE = 0;
        const int MAXSCORE = 100;
        const int ENDSCORE = 999;
        const String INV = "INVALID SCORE";

        static void Main(string[] args)
        {
            int testScore = 0;
            int sumScore = 0;
            decimal avgScore = 00m;
            int numScore = 0;
            int highScore = -1;
            int lowScore = 0;
            string msg = "";

            while (testScore != ENDSCORE)
            {
                Console.Write("Please enter a test score: ");
                testScore = Convert.ToInt32(Console.ReadLine());

                if (testScore == ENDSCORE)
                {
                    break;
                }
                
                if((testScore < MINSCORE) || (testScore > MAXSCORE))
                {
                    Console.WriteLine(INV);
                }

                else
                {
                    ++numScore;
                    sumScore += testScore;

                    if (testScore > highScore)
                    {
                        highScore = testScore;
                    }

                    if (testScore > lowScore)
                    {
                        lowScore = testScore;
                    }
                }
            }
            avgScore = (decimal) sumScore / (decimal) numScore;

            msg += "\nNumber Of Scores: " + numScore.ToString();
            msg += "\nSum Of Test Scores: " + sumScore.ToString("n1");
            msg += "\nAvg Of Test Scores: " + avgScore.ToString("n1");
            msg += "\nLowest Test Scores: " + lowScore.ToString("n1");
            msg += "\nHighest Test Scores: " + highScore.ToString("n1");
            Console.WriteLine(msg);

            Console.ReadLine();
        }
    }
}
