using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace wk4_ex1_rework
{
    internal class Program
    {
        const double USD_TO_EUR = 0.96; // money conversion constaant rates 
        const double USD_TO_JPY = 152.20; // usd to jpy conversion rate
        const double EUR_TO_JPY = 158.18; // eur to jpy conversion rate
        const double EUR_TO_USD = 1.04; // eur to usd conversion rate
        const double JPY_TO_USD = 0.0066; // jpy to usd conversion rate
        const double JPY_TO_EUR = 0.0064;   // jpy to eur conversion rate

        public static double ConvertCurrency(double amount, string fromCurrency, string toCurrency) // method to convert currency
        {
            switch (fromCurrency + "_" + toCurrency) // switch statement to check the currency conversion makes the code look neater
            {
                case "USD_EUR": // usd to eur conversion
                    return amount * USD_TO_EUR; // usd to eur conversion
                case "USD_JPY":
                    return amount * USD_TO_JPY; //returns the converted amount
                case "EUR_JPY":
                    return amount * EUR_TO_JPY; //returns the convered amount
                case "EUR_USD":
                    return amount * EUR_TO_USD; //returns the converted amount
                case "JPY_USD":
                    return amount * JPY_TO_USD; //returns the converted amount
                case "JPY_EUR":
                    return amount * JPY_TO_EUR; //returns the converted amount
                default:
                    return -1; // invalid input
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Currency Converter!"); //title of the program

            Console.WriteLine("Please enter the amount of money you want to convert:"); //prompts the user into the money they want to convert
            double amount = Convert.ToDouble(Console.ReadLine()); //saves the amount the user wants to conver to a double variable

            Console.WriteLine("Please enter the currency you want to convert from (USD, EUR, JPY):"); //prompts the user into the currency they want to convert from
            string fromCurrency = Console.ReadLine().ToUpper(); //saves the currency the user wants to convert from to a string variable

            Console.WriteLine("Please enter the currency you want to convert to (USD, EUR, JPY):"); //prompts the user into the currency they want to convert to
            string toCurrency = Console.ReadLine().ToUpper(); //saves the currency the user wants to convert to to a string variable

            double result = ConvertCurrency(amount, fromCurrency, toCurrency); //calls the ConvertCurrency method to convert the currency

            if (result >= 0) //checks if the result is valid
            {
                Console.WriteLine($"The converted amount is: {result} {toCurrency}"); //prints the converted amount
            }
            else //if the result is invalid
            {
                Console.WriteLine("Invalid currency conversion, try again"); //prints an error message
            }
            
            
        }
    }
}

            
               


            
    

