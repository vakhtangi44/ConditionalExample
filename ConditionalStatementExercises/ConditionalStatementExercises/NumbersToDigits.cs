﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatementExercises
{
    internal class NumbersToDigits
    {
        public void Solution()
        {
            //.Write a program in C# Sharp to read any digit, display in the word.
            Console.WriteLine("Write a program in C# Sharp to read any digit, display in the word.");
            Console.WriteLine("Enter number (from 0 to 9) : ");
            int digit = Convert.ToInt32(Console.ReadLine());

            switch (digit)
            {
                case 0:
                    Console.WriteLine("Zero. ");
                    break;
                case 1:
                    Console.WriteLine("One.");
                    break;
                case 2:
                    Console.WriteLine("Two.");
                    break;
                case 3:
                    Console.WriteLine("Three.");
                    break;
                case 4:
                    Console.WriteLine("Four.");
                    break;
                case 5:
                    Console.WriteLine("Five.");
                    break;
                case 6:
                    Console.WriteLine("Six.");
                    break;
                case 7:
                    Console.WriteLine("Seven.");
                    break;
                case 8:
                    Console.WriteLine("Eight.");
                    break;
                case 9:
                    Console.WriteLine("Nine.");
                    break;
                default:
                    Console.WriteLine("Invalid digit. Please try again ...");
                    break;

            }
        }
    }
}