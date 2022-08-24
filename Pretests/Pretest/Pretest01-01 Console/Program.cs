using System;
/*
1-1b
Write C# GUI program Pretest01-02 that converts distances from miles to kilometers and: 
Declare a named constant named KM_PER_MILE which holds the number of kilometers in a mile (1.6 km per mile). 
Prompt the user for a distance in miles. 
Display the distance in both kilometers and miles. For example: "3.0 miles is 4.8 kilometers" 
Set the AcceptButton, CancelButton, StartPosition, and Tab Order accordingly.  
 */

namespace Pretest01_01_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declare each testScore variable as the
            Console.Write("Please enter test score 1");
            int testScore1 = Convert.ToInt32(Console.ReadLine()); 
            Console.Write("\nPlease enter test score 2");
            int testScore2 = Convert.ToInt32(Console.ReadLine()); 
            Console.Write("\nPlease enter test score 3");
            int testScore3 = Convert.ToInt32(Console.ReadLine()); 
            Console.Write("\nPlease enter test score 4");
            int testScore4 = Convert.ToInt32(Console.ReadLine());
            

            // totScore is the sum fo the four test scores
            int totScore = testScore1 + testScore2 +
                testScore3 + testScore4;

            // avgScore is the totScore divided by 4 (# of test)
            decimal avgScore = totScore / 4.0m;

            Console.WriteLine("Test Score1: " + testScore1.ToString());
            Console.WriteLine("Test Score2: " + testScore1.ToString());
            Console.WriteLine("Test Score3: " + testScore1.ToString());
            Console.WriteLine("Test Score4: " + testScore1.ToString());
            Console.WriteLine("Test Score Avg: " + avgScore.ToString("n2"));

            Console.ReadLine();
        }
    }
}
