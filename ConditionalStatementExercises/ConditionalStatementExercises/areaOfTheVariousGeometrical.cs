using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatementExercises
{
    internal class areaOfTheVariousGeometrical
    {
        public void Solution()
        {
            //Write a program in C# Sharp which is a Menu-Driven Program to compute
            //the area of the various geometrical shape.
            Console.WriteLine("This program is a Menu-Driven Program to compute the area of the various geometrical shape.");
            Console.WriteLine("Input 1 for area of circle");
            Console.WriteLine("Input 2 for area of rectangle");
            Console.WriteLine("Input 3 for area of triangle");
            Console.WriteLine("Input your choice : ");
            int choice = Convert.ToInt32(Console.ReadLine());
            double area = 0;
            Console.WriteLine("A menu driven program to compute the area of various geometrical shape:\n");
            
            switch (choice)
            {
                case 1:
                    Console.Write("Input radius of the circle : ");
                    int radius = Convert.ToInt32(Console.ReadLine());
                    area = 3.14 * radius * radius;
                    break;
                case 2:
                    Console.Write("Input length  of the rectangle : ");
                    int length = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Input  width of the rectangle : ");
                    int width = Convert.ToInt32(Console.ReadLine());
                    area = length * width;
                    break;
                case 3:
                    Console.Write("Input the base of the triangle :");
                    int baseOfTriangle = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Input the hight of the triangle :");
                    int hight = Convert.ToInt32(Console.ReadLine());
                    area = (baseOfTriangle * hight)/2;
                    break;
            }
            Console.Write($"The area is : {area}");
        }
    }
}

