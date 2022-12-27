using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatementExercises
{
    internal class ElectricityBill
    {
        public void Solution()
        {
            //Write a program in C# Sharp to calculate and print the Electricity bill of a given customer.
            //The customer id., name and unit consumed by the user should be taken from the keyboard
            //and display the total amount to pay to the customer.


            Console.WriteLine("Please type Customer IDNO: ");
            int customerIDNO = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter Customer name: ");
            string customerName = Console.ReadLine().ToLower();
            Console.WriteLine("Please enter unit consumed");
            int unitConsumed = Convert.ToInt32(Console.ReadLine());
            double charge, surchageAmount = 0, totalAmount, netAmount;


            if (unitConsumed < 200)
            {
                charge = 1.20;
            }
            else if (unitConsumed >= 200 && unitConsumed < 400)
            {
                charge = 1.50;
            }
            else if (unitConsumed >= 400 && unitConsumed < 600)
            {
                charge = 1.80;
            }
            else
            {
                charge = 2.00;
            }
            totalAmount = unitConsumed * charge;
            if (totalAmount > 300)
            {
                surchageAmount = totalAmount * 0.15;
            }
            netAmount = totalAmount + surchageAmount;
            if (netAmount < 100)
            {
                netAmount = 100;
            }
            Console.WriteLine($"Customer IDNO: {customerIDNO} ");
            Console.WriteLine($"Customer Name:  {customerName} ");
            Console.WriteLine($"unit Consumed: {unitConsumed} ");
            Console.WriteLine($"Amount Charges @Rs. {charge}  per unit: {totalAmount}");
            Console.WriteLine($"Surchage amount: {surchageAmount}");
            Console.WriteLine($"Net Amount Paid By the Customer: {netAmount}");
        }
    }
}
