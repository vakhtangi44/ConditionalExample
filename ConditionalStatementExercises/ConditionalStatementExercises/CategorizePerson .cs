using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatementExercises
{
    internal class CategorizePerson
    {
        public void Solution()
        {
            //Write a C# Sharp program to accept the height of a person in centimeter
            //and categorize the person according to their height.
            Console.WriteLine("This program to accept the height of a person in centimeter" +
                " and categorize the person according to their height.");
            Console.WriteLine("Enter your height: ");
            var Height = Convert.ToUInt32(Console.ReadLine());
            if (Height <= 150)
            {
                Console.WriteLine("The person is Dwarf.");
            }
            else if (Height >= 150 && Height <= 180)
            {
                Console.WriteLine("The person is Normal");
            }
            else
            {
                Console.WriteLine("The person is High");
            }


        }
    }
}
