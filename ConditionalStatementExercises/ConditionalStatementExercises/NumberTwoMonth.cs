using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatementExercises
{
    internal class NumberTwoMonth
    {
        public void Solution()
        {
            //Write a program in C# Sharp to read any Month Number in integer and
            //display Month name in the word.
            Console.WriteLine("This program read any Month Number in integer and display Month name in the word.");
            Console.WriteLine("Enter number: ");
            int monthNumber = Convert.ToInt32(Console.ReadLine());

            switch (monthNumber)
            {
                case 1:
                    Console.WriteLine("January");
                    break;
                case 2:
                    Console.WriteLine("February");
                    break;
                case 3:
                    Console.WriteLine("March");
                    break;
                case 4:
                    Console.WriteLine("April");
                    break;
                case 5:
                    Console.WriteLine("May");
                    break;
                case 6:
                    Console.WriteLine("June");
                    break;
                case 7:
                    Console.WriteLine("July");
                    break;
                case 8:
                    Console.WriteLine("August");
                    break;
                case 9:
                    Console.WriteLine("September");
                    break;
                case 10:
                    Console.WriteLine("October");
                    break;
                case 11:
                    Console.WriteLine("November");
                    break;
                case 12:
                    Console.WriteLine("December");
                    break;
                default:
                    Console.WriteLine("invalid Month number. Please try again ....");
                    break;
            }
        }
    }
}
