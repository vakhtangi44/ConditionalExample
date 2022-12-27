using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatementExercises
{
    internal class EqualOrNot
    {
        public void Solution()
        {

            //Write a C# Sharp program to accept two integers and check whether they are equal or not.          
            

            Console.WriteLine("This program takes two integers and check whether they are equal or not.");
            Console.WriteLine("Enter first number: ");
            int FirstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int SecondNumber = Convert.ToInt32(Console.ReadLine());
            if (FirstNumber == SecondNumber)
            {
                Console.WriteLine("They are equal!");
            }
            else
            {
                Console.WriteLine("They are not equal!");
            }
        }
    }
}
