using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * You can randomly generate three numbers as follows:

Random rand = new Random();
int num1 = rand.Next(1, 4);
int num2 = rand.Next(1, 11);
int num3 = rand.Next(1, 101);
Console.WriteLine(“{0}, {1}, {2}”, num1, num2, num3);

See here for the official documentation of the Random class:
https://msdn.microsoft.com/en-us/library/system.random(v=vs.110).aspx

Build a GUI program that allows the user to play three rounds of Rock Paper Scissors. 
Once all three rounds are over, display the winner.
 
*/

namespace Chapt5Lab4
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmHurricanScale());
        }
    }
}
