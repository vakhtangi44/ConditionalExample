using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatementExercises
{
    internal class Task15

    {
        static int TringCon = 180;
        public void Solution()
        {
            //Write a C# Sharp program to check whether a triangle can be formed by the given value for the angles.
            Console.WriteLine("This program check whether a triangle can be formed by the given value for the angles.");
            Console.WriteLine("Enter angle A: ");
            int angleA= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter angle B: ");
            int angleB= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter angle C: ");
            int angleC= Convert.ToInt32(Console.ReadLine());
            if ((angleA + angleB + angleC) == TringCon)
            {
                Console.WriteLine("The triangle is valid");
            }
            else
            {
                Console.WriteLine("The triangle is not valid.");
            }
        }
    }
}
