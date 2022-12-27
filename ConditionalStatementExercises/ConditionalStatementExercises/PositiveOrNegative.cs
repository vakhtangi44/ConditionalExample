using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatementExercises
{
    internal class PositiveOrNegative
    {
        public void Solution()
        {
            //Write a C# Sharp program to check whether a given number is positive or negative.
            Console.WriteLine("This program check whether a given number is positive or negative");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number >= 0)
            {
                Console.WriteLine("Number is positive!");
            }
            else
            {
                Console.WriteLine("Number is negative");
            }

        }
    }
}
