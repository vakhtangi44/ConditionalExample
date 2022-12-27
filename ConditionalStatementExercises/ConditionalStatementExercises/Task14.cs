using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatementExercises
{
    internal class Task14
    {
        public void Solution()
        {
            //Write a C# Sharp program to check whether a triangle is Equilateral, Isosceles or Scalene.
            Console.WriteLine("This program check whether a triangle is Equilateral, Isosceles or Scalene.");
            Console.WriteLine("Check whether a triangle is Equilateral, Isosceles or Scalene:");

            Console.WriteLine("Input side A of triangle: ");
            int sideA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input side B of triangle: ");
            int sideB = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input side C of triangle: ");
            int sideC = Convert.ToInt32(Console.ReadLine());


            if (sideA == sideB && sideB == sideC)
            {
                Console.WriteLine("This is an equilateral triangle.");
            }
            else if (sideA == sideB || sideA == sideC || sideB == sideC)
            {
                Console.WriteLine("This is an isosceles triangle.");
            }
            else
            {
                Console.WriteLine("This is a scalene triangle.");
            }
        }
    }
}
