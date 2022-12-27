using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatementExercises
{
    internal class LeapYear
    {
        public void Solution()
        {
            //Write a C# Sharp program to find whether a given year is a leap year or not.
            Console.WriteLine("This program to find whether a given year is a leap year or not.");
            Console.WriteLine("Enter year!");
            int Year = Convert.ToInt32(Console.ReadLine());
            bool Leap = Year % 4 == 0;
            if (Leap)
            {
                Console.WriteLine("Year is leap");
            }
            else
            {
                Console.WriteLine("Year is not leap");
            }
        }
    }
}
