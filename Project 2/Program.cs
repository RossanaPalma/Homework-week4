/// Chapter No. 9 and 10 - Homework_week4
/// File Name: homework_week4.java
/// @author: Rossana Palma
/// Date:  September 19, 2021
///
/// Problem Statement: Write a program that determines the change to be dispensed from a vending machine.
/// 
/// 
/// Overall Plan:
/// 1) Declare variables
/// 2) Prompt user for price and convert text to int
/// 3) Calculate change to be dispense from a vending machine
/// 4) Display results on the screen


using System;

namespace Project_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare variables
            int item1, item2, item3, item4, amount;

            //Prompt user for price
            Console.WriteLine("Enter price of item (from 25 cents to a dollar, in 5-cent increments):");
            String inputPrice;
            inputPrice = Console.ReadLine();
            //Convert to int
            item1 = Int32.Parse(inputPrice);

            // Calculations
            amount = 100 - item1;
            item2 = amount / 25;
            amount = amount % 25;
            item3 = amount / 10;
            item4 = amount / 5;

            // Display

            Console.WriteLine("You bought an item for " + item1 + " cents and gave me a dollar, so your change is: ");
            Console.WriteLine(item2 + " quarters");
            Console.WriteLine(item3 + " dimes");
            Console.WriteLine(item4 + " nickles");
        }
    }
}
