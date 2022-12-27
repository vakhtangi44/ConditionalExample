using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatementExercises
{
    internal class DeclareEquivalent
    {
        public void Solution()
        {
            //Write a program in C# Sharp to accept a grade and declare the equivalent description
            Console.WriteLine("This program accept a grade and declare the equivalent description");
            Console.WriteLine("Enter Grade: ");
            char grade = Convert.ToChar(Console.ReadLine().ToUpper());
            switch (grade)
            {
                case 'E':
                    Console.WriteLine("You have chosen  : Excellent");
                    break;
                case 'V':
                    Console.WriteLine("You have chosen  : Very Good");
                    break;
                case 'G':
                    Console.WriteLine("You have chosen  : Good ");
                    break;
                case 'A':
                    Console.WriteLine("You have chosen  : Average");
                    break;
                case 'F':
                    Console.WriteLine("You have chosen  : Fails");
                    break;
                default:
                    Console.WriteLine("Invalid Grade Found.");
                    break;
            }
        }

    }
}
