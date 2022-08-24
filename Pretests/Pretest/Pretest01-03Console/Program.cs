using System;
/*
 Write C# console program Pretest01-03 that lets a user enter a number grade and displays the associated 
 letter grade. Include constants MINGRADE (0) and MAXGRADE (100).  
 
 The associated letter grade code we used is shown below: 

90 - 100 = A
80 -89 =B
70 - 79 = C
60 - 69 = D
0 - 59 = F
 * 
 */

namespace Pretest01_03Console
{
    internal class Program
    {
        //Program Constants
        const int MINGRADE = 0; //Lowest possible grade
        const int MAXGRADE = 100; // Highest possible grade
        static void Main(string[] args)
        {
            Console.Write("Enter Grade (0-100): ");
            int numberGrade = Convert.ToInt32(Console.ReadLine());
            string letterGrade = "";

            if ((numberGrade > MAXGRADE) ||
                (numberGrade < MINGRADE))
            {
                letterGrade = "Invalid Number Grade";
            }

            else if (numberGrade >= 90)
            {
                letterGrade = "A";
            }

            else if (numberGrade >= 80)
            {
                letterGrade = "B";
            }

            else if (numberGrade >= 70)
            {
                letterGrade = "C";
            }

            else if (numberGrade >= 60)
            {
                letterGrade = "D";
            }

            else if (numberGrade >= MINGRADE)
            {
                letterGrade = "F";
            }

            Console.WriteLine("\nNumber Grade was : " + numberGrade.ToString() +
                 "\nLetter Grade was : " + letterGrade.ToString());

            Console.Read();

        }
    }
}
