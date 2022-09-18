using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Write a console program that calculates the average grade for a student:
●	Prompts the user for four test scores
●	Displays the average of the entered test scores

 * 
 * */

namespace Ch2_3LB6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declare each testScore variable
            int testScore1;
            int testScore2;
            int testScore3;
            int testScore4;
            int totScore;
            decimal avgScore;


             
            Console.Write("Please enter test score 1: ");
            testScore1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nPlease enter test score 2: ");
            testScore2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nPlease enter test score 3: ");
            testScore3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nPlease enter test score 4: ");
            testScore4 = Convert.ToInt32(Console.ReadLine());


            // totScore is the sum fo the four test scores
            totScore = testScore1 + testScore2 +
                testScore3 + testScore4;

            // avgScore is the totScore divided by 4 (# of test)
            avgScore = totScore / 4.0m;

            //Console.WriteLine("Test Score1: " + testScore1.ToString());
            //Console.WriteLine("Test Score2: " + testScore2.ToString());
            //Console.WriteLine("Test Score3: " + testScore3.ToString());
            //Console.WriteLine("Test Score4: " + testScore4.ToString());
            Console.WriteLine("Test Score Avg: " + avgScore.ToString("n2"));

            Console.ReadLine();

        }
    }
}
