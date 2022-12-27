using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatementExercises
{
    internal class SimpleCalculator
    {
        public void Solution()
        {
            Console.WriteLine("A menu driven program for a simple calculator:");
            Console.WriteLine("Enter the first Integer :");
            double numberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second Integer :");
            double numberTwo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Here are the options :");
            Console.WriteLine("1-Addition. 2-Substraction. 3-Multiplication. 4-Division. 5-Exit. ");
            Console.WriteLine("Input your choice :");
            double option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine($"The Addition of  {numberOne} and {numberTwo} is: {numberOne + numberTwo}");
                    break;
                case 2:
                    Console.WriteLine($"The Substraction of {numberOne}  and {numberTwo} is: {numberOne-numberTwo}");
                    break;
                case 3:
                    Console.WriteLine($"The Multiplication of {numberOne}  and {numberTwo} is: {numberOne*numberTwo}");
                    break;
                case 4:
                    if (numberTwo == 0)
                    {
                        Console.WriteLine("The second integer is zero. Devide by zero.");
                    }
                    else
                    {
                        Console.WriteLine($"The Division of {numberOne}  and {numberTwo} is : {numberOne/numberTwo}");
                    }
                    break;
                case 5:
                    break;
                default:
                    Console.WriteLine("Input correct option");
                    break;
            }
        }
    }
}