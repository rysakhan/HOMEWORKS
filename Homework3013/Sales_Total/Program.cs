﻿using System;

namespace Sales_Total
{
    class Program
    {
        const double TAXRATE = 0.085;

        static void Main(string[] args)
        {
            //string itemQuantity;
            //string itemPrice;

            Console.WriteLine("What is the name of the item you bought?");
            string itemName = Console.ReadLine();

            Console.WriteLine("What is the price of each " + itemName + "?");
            double itemPrice = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("How many " + itemName + " did you buy?");
            int itemQuantity = Convert.ToInt32(Console.ReadLine());

            double subTotal = itemPrice * itemQuantity;
            double taxTotal = subTotal * TAXRATE;
            double total = taxTotal + subTotal;

            Console.WriteLine("Your subtotal for your bill is " + subTotal.ToString("C2") + ".");
            Console.WriteLine("Your sales tax for your bill is " + taxTotal.ToString("C2") + ".");
            Console.WriteLine("Your sales total for your bill is " + total.ToString("C2") + ".");

        }
    }
}
