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
        const double USD_TO_EUR = 0.96;
        const double USD_TO_JPY = 152.20;
        const double EUR_TO_JPY = 158.18;
        const double EUR_TO_USD = 1.04;
        const double JPY_TO_USD = 0.0066;
        const double JPY_TO_EUR = 0.0064;

        public static double ConvertCurrency(double amount, string fromCurrency, string toCurrency)
        {
            switch (fromCurrency + "_" + toCurrency)
            {
                case "USD_EUR":
                    return amount * USD_TO_EUR;
                case "USD_JPY":
                    return amount * USD_TO_JPY;
                case "EUR_JPY":
                    return amount * EUR_TO_JPY;
                case "EUR_USD":
                    return amount * EUR_TO_USD;
                case "JPY_USD":
                    return amount * JPY_TO_USD;
                case "JPY_EUR":
                    return amount * JPY_TO_EUR;
                default:
                    return -1; // invalid input
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Currency Converter!");

            Console.WriteLine("Please enter the amount of money you want to convert:");
            double amount = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the currency you want to convert from (USD, EUR, JPY):");
            string fromCurrency = Console.ReadLine().ToUpper();

            Console.WriteLine("Please enter the currency you want to convert to (USD, EUR, JPY):");
            string toCurrency = Console.ReadLine().ToUpper();

            double result = ConvertCurrency(amount, fromCurrency, toCurrency);

            if (result >= 0)
            {
                Console.WriteLine($"The converted amount is: {result} {toCurrency}");
            }
            else
            {
                Console.WriteLine("Invalid currency conversion, try again");
            }
        }
    }
}

            
               


            
    

