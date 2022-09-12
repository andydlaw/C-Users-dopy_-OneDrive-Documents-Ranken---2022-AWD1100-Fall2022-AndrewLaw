using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            double percent = 0.54;
            bool valid = true;
            int counter = 1;
            if (percent > 0.50 && valid)
            {
                counter += 2;
                if (valid)
                    counter++;
                else if (percent >= 0.50)
                    counter += 3;
            }
            else
            {
                counter++;
            }






            Console.WriteLine(counter);
            Console.ReadLine();
        }
    }
}
