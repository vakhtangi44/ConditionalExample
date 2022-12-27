using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatementExercises
{
    internal class Task6
    {
        public void Solution()
        {
            //Write a C# Sharp program to read the value of an integer m and
            //display the value of n is 1 when m is larger than 0,
            //0 when m is 0 and -1 when m is less than 0. 
            Console.WriteLine("enter number");
            int m = Convert.ToInt32(Console.ReadLine());
            int n=0;
            if (m > 0)
            {
                n=1;
            }
            else if (m == 0)
            {
                n=0;
            }
            else if (m < 0)
            {
                n=-1;
            }
            Console.WriteLine($"The value of m = {m}");
            Console.WriteLine($"The value of n = {n}");
            
        }
    }
}
