using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatementExercises
{
    internal class LargestNumber
    {
        public void Solution()
        {
            //Write a C# Sharp program to find the largest of three numbers.
            Console.WriteLine(" This program find the largest of three numbers. ");
            Console.WriteLine("Enter first number :");
            int FirstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int SecondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third number: ");
            int ThirdNumber = Convert.ToInt32(Console.ReadLine());

            if (FirstNumber > SecondNumber || FirstNumber > ThirdNumber)
            {
                Console.WriteLine("First number is the greatest among three");
            }
            else if (SecondNumber > ThirdNumber || SecondNumber > FirstNumber)
            {
                Console.WriteLine("Second number is the greatest among three");
            }
            else if (ThirdNumber > FirstNumber || ThirdNumber > SecondNumber)
            {
                Console.WriteLine("Third number is the greatest among three");
            }
        }
    }
}
