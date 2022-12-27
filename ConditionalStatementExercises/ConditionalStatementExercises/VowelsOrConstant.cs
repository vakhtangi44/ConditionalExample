using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatementExercises
{
    internal class VowelsOrConstant
    {
        public void Solution()
        {
            //Write a C# Sharp program to check whether an alphabet is a vowel or consonant.
            Console.WriteLine("This program check whether an alphabet is a vowel or consonant.");
            Console.WriteLine("Type alphabet: ");
            char alphabet = Convert.ToChar(Console.ReadLine().ToLower());
            switch (alphabet)
            {
                case 'a':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
                case 'i':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
                case 'o':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
                case 'u':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
                case 'e':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
                default:
                    Console.WriteLine("The Alphabet is not a vowel");
                    break;
            }
        }
    }
}
