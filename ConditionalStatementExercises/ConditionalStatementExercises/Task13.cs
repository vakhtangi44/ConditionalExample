using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatementExercises
{
    internal class Task13
    {

        public void Solution()
        {
            //Write a C# Sharp program to read temperature in centigrade and display a suitable message according to temperature
            Console.WriteLine("This program read temperature in centigrade and display a suitable message according to temperature");
            Console.WriteLine("Type temperature");
            int temperature = Convert.ToInt32(Console.ReadLine());
            if (temperature < 0)
            {
                Console.WriteLine("Freezing weather");
            }
            else if (temperature > 0 && temperature < 10)
            {
                Console.WriteLine("Very Cold weather");
            }
            else if (temperature > 10 && temperature < 20)
            {
                Console.WriteLine("Cold weather");
            }
            else if (temperature > 20 && temperature < 30)
            {
                Console.WriteLine("Normal in Temp");
            }
            else if (temperature > 30 && temperature < 40)
            {
                Console.WriteLine("Its Hot");
            }
            else
            {
                Console.WriteLine("Its Very Hot");
            }
        }
    }
}
