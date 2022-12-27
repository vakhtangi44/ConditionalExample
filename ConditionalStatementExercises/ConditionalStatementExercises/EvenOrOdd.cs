using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatementExercises
{
    internal class EvenOrOdd
    {
        public void Solution()
        {
            //Write a C# Sharp program to check whether a given number is even or odd.
            Console.WriteLine("This program check whether a given number is even or odd");
            var number = Convert.ToInt32(Console.ReadLine());
            if(number%2==0)
            {
                Console.WriteLine("Number is even");
            }
            else
            {
                Console.WriteLine("Number is odd");
            }
        }
    }
}
