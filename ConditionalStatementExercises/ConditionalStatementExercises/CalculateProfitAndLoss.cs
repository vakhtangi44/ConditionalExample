using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatementExercises
{
    internal class CalculateProfitAndLoss
    {
        public void Solution()
        {
            //Write a C# Sharp program to calculate profit and loss on a transaction.
            Console.WriteLine("This program to calculate profit and loss on a transaction.");
            Console.WriteLine("Enter cost price: ");
            int costPrice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter selling price ");
            int sellingPrice = Convert.ToInt32(Console.ReadLine());
            int profitAmount;
            if (costPrice > sellingPrice)
            {
                profitAmount = costPrice - sellingPrice;
                Console.WriteLine($"You got a loss of amount {profitAmount} ");
            }
            else if (costPrice < sellingPrice)
            {
                profitAmount = sellingPrice - costPrice;
                Console.WriteLine($"You booked your profit amount {profitAmount} ");
            }
            else
            {
                profitAmount = 0;
                Console.WriteLine("Your are running in no profit no loss condition");
            }
        }
    }
}
