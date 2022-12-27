using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatementExercises
{
    internal class EligibleForCasting
    {
        public void Solution() 
        {
            //Write a C# Sharp program to read the age of a candidate and
            //determine whether it is eligible for casting his/her own vote
            Console.WriteLine("This program to read the age of a candidate and determine whether it is eligible for casting his/her own vote");
            Console.WriteLine("Enter your age");
            int Age = Convert.ToInt32(Console.ReadLine());
            bool Eligible = Age >= 18;
            if(Eligible)
            {
                Console.WriteLine("Congratulation! You are eligible for casting your vote");
            }
            else
            {
                Console.WriteLine("Unfortunatly, you are not eligible for casting your vote");
            }
        }
    }
}
