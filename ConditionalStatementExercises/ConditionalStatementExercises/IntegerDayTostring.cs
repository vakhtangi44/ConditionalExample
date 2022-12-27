using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatementExercises
{
    internal class IntegerDayTostring
    {
        public void Solution()
        {
            //. Write a program in C# Sharp to read any day number in integer
            //and display day name in the word. 
            Console.WriteLine("This program read any day number in integer and display day name in the word. ");
            Console.WriteLine("Enter number (from 1 to 7) : ");
            int weekDay = Convert.ToInt32(Console.ReadLine());
            
            switch (weekDay)
            {
                case 1:
                    Console.WriteLine("Monday ");
                    break;
                case 2:
                    Console.WriteLine("Tuesday ");
                    break;
                case 3:
                    Console.WriteLine("Wednesday ");
                    break;
                case 4:
                    Console.WriteLine("Thursday ");
                    break;
                case 5:
                    Console.WriteLine("Friday ");
                    break;
                case 6:
                    Console.WriteLine("Saturday ");
                    break;
                case 7:
                    Console.WriteLine("Sunday  ");
                    break;
                default:
                    Console.WriteLine("Invalid day number. Please try again ...");
                    break;

            }
        }
    }
}
