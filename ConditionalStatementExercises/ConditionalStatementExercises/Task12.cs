using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatementExercises
{
    internal class Task12
    {
        public void Solution()
        {
            //Write a C# Sharp program to read roll no, name and marks of three subjects
            //and calculate the total, percentage and division.
            Console.WriteLine("This program read roll no, name and marks of three subjects and calculate the total, percentage and division.");
           
            
            string  division;

           
            Console.WriteLine("Calculate the total, percentage and division to take marks of three subjects:");

            Console.WriteLine("Input the Roll Number of the student :");
           double rollNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the Name of the Student :");
           string nameOfStudent = Console.ReadLine();

            Console.WriteLine("Input  the marks of Physics : ");
            double physicsMark = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input  the marks of  Chemistry : ");
            double chemistryMark = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input  the marks of Computer Application : ");
            double computarAplication = Convert.ToInt32(Console.ReadLine());

            double total = physicsMark + chemistryMark + computarAplication;
            double percentage = total / 3.0;
            if (percentage >= 60)
                 division = "First";
            else
            if ( percentage< 60 && percentage >= 48)
                division  = "Second";
            else
                if (percentage < 48 && percentage >= 36)
                division = "Pass";
            else
                division = "Fail";

            Console.WriteLine($"Roll No : {rollNumber}Name of Student : {nameOfStudent}");
            Console.WriteLine($"Marks in Physics : {physicsMark}Marks in Chemistry : {chemistryMark}Marks in Computer Application : {computarAplication}");
            Console.WriteLine($"Total Marks = {total} Percentage = {percentage} Division = {division}");
        }
    }
}
