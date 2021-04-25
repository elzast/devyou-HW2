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

            //Exercise 3: Tip Calculator
            //Prompt the user to give you the total bill
            Console.WriteLine("What is your total bill?");
            double userTotalBill = double.Parse(Console.ReadLine());
            //Prompt the user to give you what percent they would like to tip
            Console.WriteLine("How much would you like to tip? Enter the amount in a decimal.  Example : .15");
            double userEnteredTip = double.Parse(Console.ReadLine());
            //Display to the user the amount of tip they would owe
            double tipAmount = userTotalBill * userEnteredTip;
            Console.WriteLine($"You should tip {tipAmount}");

            //Exercise 4: Bill Dividends
            //Prompt the user to give you the total bill
            Console.WriteLine("What is the total of this bill?");
                double totalOfBill = double.Parse(Console.ReadLine());
            //Prompt the user to give you how many people are contributing
            Console.WriteLine("How many people are contributing to paying this bill?");
            int peoplePaying = Int32.Parse(Console.ReadLine());
            //Display to the user, the amount each contributor would need to pay
            double amountPaidPerPerson = totalOfBill / peoplePaying;
            Console.WriteLine($"The amount owed per person is {amountPaidPerPerson}");

            /*Challenge: Formatting Money
            This challenge may require using a developer’s most utilized tool; Google.There are several different ways to format money. When we say format money - we are basically asking to write a string that shows money as you’d see it on a price tag(like this → $199.95).

            Formatting a double(or decimal) requires you to
            show a $ sign, 
            a decimal and
            two digits after the decimal*/

            //Requirements:
            //Create a double variable and assign it value
            //Make sure the numbers round properly
            //Make sure if you have a number that ends in .00 it should still show .00
            //i.e. $10 should print as $10.00
            //Make sure commas are separated for every three digits to the left of the decimal point
            //I.e. $1000 should print as $1, 000.00

            decimal testNumber = 5212.6312M;
            Console.WriteLine(testNumber.ToString("C"));

            double testNumber2 = 533333.33;
            Console.WriteLine(testNumber2.ToString("C"));


        }
    }
}
