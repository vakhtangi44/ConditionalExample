using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatementExercises
{
    internal class DetermineCordinate
    {
        public void Solution()
        {
            //Write a C# Sharp program to accept a coordinate point in an XY coordinate system
            //and determine in which quadrant the coordinate point lies
            Console.WriteLine("This program accept a coordinate point in an XY coordinate system and determine in which quadrant the coordinate point lies");
            Console.WriteLine("Enter X cordinate:");
            int Xcordinate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Y cordinate: ");
            int Ycordinate = Convert.ToInt32(Console.ReadLine());
            if (Xcordinate > 0 && Ycordinate > 0)
            {
                Console.WriteLine($"The coordinate point ({Xcordinate},{Ycordinate}) lies in the First quadrant.");
            }
            else if (Xcordinate > 0 && Ycordinate < 0)
            {
                Console.WriteLine($"The coordinate point ({Xcordinate},{Ycordinate}) lies in the Fourth quadrant.");
            }
            else if (Xcordinate < 0 && Ycordinate > 0)
            {
                Console.WriteLine($"The coordinate point ({Xcordinate},{Ycordinate}) lies in the Second quadrant.");
            }
            else if (Xcordinate<0&&Ycordinate<0)
            {
                Console.WriteLine($"The coordinate point ({Xcordinate},{Ycordinate}) lies in the Third quadrant.");
            }
            else
            {
                Console.WriteLine($"The coordinate point ({Xcordinate}, {Ycordinate}) lies at the origin.");
            }

        }
    }
}
