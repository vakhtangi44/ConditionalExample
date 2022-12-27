using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatementExercises
{
    internal class numbersOfDayInMonth
    {
        public void Solution()
        {
            //Write a program in C# Sharp to read any Month Number in integer
            //and display the number of days for this month.
            Console.WriteLine("This program read any Month Number in integer and display the number of days for this month.");
            Console.WriteLine("Enter month number: ");
            int monthNumber = Convert.ToInt32(Console.ReadLine());

            switch (monthNumber)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("Month have 31 days");
                    break;
                case 2:
                    Console.WriteLine("Month have 28 or 29 days");
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("Month have 30 days");
                    break;

                default:
                    Console.WriteLine("invalid Month number. Please try again ....");
                    break;
            }
        }
    }
}
