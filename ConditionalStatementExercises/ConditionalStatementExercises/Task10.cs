using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatementExercises
{
    internal class Task10
    {
        static int PhyMin = 55;
        static int MathMin = 65;
        static int CheMin = 50;
        static int TotalThreeSub = 180;
        static int TotalMathPhy = 140;

        public void Solution()
        {
            //Write a C# Sharp program to find the eligibility of admission
            //for a professional course based on the following criteria:

            Console.WriteLine("Find eligibility for admission : ");
            Console.WriteLine("Eligibility Criteria : ");
            Console.WriteLine("Marks in Maths >=65 ");
            Console.WriteLine("and Marks in Phy >=55 ");
            Console.WriteLine("and Marks in Chem>=50 ");
            Console.WriteLine("and Total in all three subject >=180 ");
            Console.WriteLine("or Total in Maths and Physics >=140");

            Console.WriteLine("Input the marks obtained in Physics :");
            int physycs = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the marks obtained in Chemistry :");
            int chemistry = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the marks obtained in Mathematics :");
            int mathematics = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Total marks of Maths, Physics and Chemistry : {mathematics + physycs + chemistry}");
            Console.WriteLine($"Total marks of Maths and  Physics : {mathematics + physycs}");

            if (mathematics >= MathMin && physycs >= PhyMin && chemistry >= CheMin &&
                ((mathematics + physycs + chemistry) >= TotalThreeSub || (mathematics + physycs) >= TotalMathPhy))
            {
                Console.WriteLine("The  candidate is eligible for admission.");
            }
            else
            {
                Console.WriteLine("The candidate is not eligible.");
            }
        }
    }
}
