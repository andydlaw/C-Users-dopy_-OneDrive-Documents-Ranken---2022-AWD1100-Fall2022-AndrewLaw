using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
Write a console program that calculates projected raises:
●	Declares a named constant PERCENT_RAISE and assign it a value of 4% (or 0.04)
●	Prompts the user for the names and salaries of three employees.
●	Displays the projected salaries for these three employees over the next 2 years in a table, assuming that they get a 4% raise every year.

+------------+------------+------------+------------+
| Year       | Bob        | Fred       | Will       |
+------------+------------+------------+------------+
| 2018       | $10,000.00 | $20,000.00 | $30,000.00 |
| 2019       | $10,400.00 | $20,800.00 | $31,200.00 |
| 2020       | $10,816.00 | $21,632.00 | $32,448.00 |
+------------+------------+------------+------------+


*/

namespace Ch2_3LB5
{
    internal class Program
    {
        const decimal PERCENT_RAISE = 1.04m;
        static void Main(string[] args)
        {
            string employeeOneName;
            decimal employeeOneSalary;
            decimal employeeOneSalaryYearTwo;
            decimal employeeOneSalaryYearThree;
            string employeeTwoName;
            decimal employeeTwoSalary;
            decimal employeeTwoSalaryYearTwo;
            decimal employeeTwoSalaryYearThree;
            string employeeThreeName;
            decimal employeeThreeSalary;
            decimal employeeThreeSalaryYearTwo;
            decimal employeeThreeSalaryYearThree;

            Console.Write("Enter Employee One Name: ");
            employeeOneName = Console.ReadLine();
            Console.Write("Enter Employee One Salary: ");
            employeeOneSalary = Convert.ToInt32(Console.ReadLine());
            employeeOneSalaryYearTwo = employeeOneSalary * PERCENT_RAISE;
            employeeOneSalaryYearThree = employeeOneSalaryYearTwo * PERCENT_RAISE;
            Console.Write("Enter Employee Two Name: ");
            employeeTwoName = Console.ReadLine();
            Console.Write("Enter Employee Two Salary: ");
            employeeTwoSalary = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Employee Three Name: ");
            employeeTwoSalaryYearTwo = employeeTwoSalary * PERCENT_RAISE;
            employeeTwoSalaryYearThree = employeeTwoSalaryYearTwo * PERCENT_RAISE;
            employeeThreeName = Console.ReadLine();
            Console.Write("Enter Employee Three Salary: ");
            employeeThreeSalary = Convert.ToInt32(Console.ReadLine());
            employeeThreeSalaryYearTwo = employeeThreeSalary * PERCENT_RAISE;
            employeeThreeSalaryYearThree = employeeThreeSalaryYearTwo * PERCENT_RAISE;
            

            Console.WriteLine("+------------+------------+------------+------------+");
            Console.WriteLine
                ("| Year       | " + employeeOneName + "        | " + employeeTwoName + "       | " + employeeThreeName + "       |");
            Console.WriteLine("+------------+------------+------------+------------+");
            Console.WriteLine
                ("| 2022       | " + employeeOneSalary.ToString("c") + " | " + employeeTwoSalary.ToString("c") + " | " + employeeThreeSalary.ToString("c") + " |");
            Console.WriteLine
                ("| 2023       | " + employeeOneSalaryYearTwo.ToString("c") + " | " + employeeTwoSalaryYearTwo.ToString("c") + " | " + employeeThreeSalaryYearTwo.ToString("c") + " |");
            Console.WriteLine
                ("| 2024       | " + employeeOneSalaryYearThree.ToString("c") + " | " + employeeTwoSalaryYearThree.ToString("c") + " | " + employeeThreeSalaryYearThree.ToString("c") + " |");

            Console.WriteLine("+------------+------------+------------+------------+");
            Console.ReadLine();
        }
    }
}
