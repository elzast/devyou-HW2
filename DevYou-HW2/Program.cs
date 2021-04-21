using System;

namespace DevYou_HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1: Fahrenheit to Celsius
            //Prompt your user for the degrees in Fahrenheit
            Console.WriteLine("Enter the temperature in Fahrenheit");
            double tempF = double.Parse(Console.ReadLine());
            //Display the degrees in Fahrenheit and its equivalent in Celsius on the Console
            double tempC = ((tempF - 32)*5)/9;
            Console.WriteLine($"{tempC} is your temperature in celsius");

            //Exercise 2: Sales Tax
            //Prompt your user for the price of their product before taxes
            Console.WriteLine("What is the price of your product before taxes?");
            double prodBeforeTax = double.Parse(Console.ReadLine());
            //Prompt the user to give you the sales tax
            Console.WriteLine("Enter your sales tax in decimal format. Example: .06");
            double userSalesTax = double.Parse(Console.ReadLine());
            //Display the total cost by calculating the price plus the sales tax to the Console
            double productWithTax = (prodBeforeTax * userSalesTax) + prodBeforeTax;
            Console.WriteLine($"The total of your product with sales tax is {productWithTax}");
        }
    }
}
