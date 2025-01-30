using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace TempCurrencyFactorial
{
    internal class Program
    {
        static int Factorial(int n)
        {
            if( n == 0) return 1; 

            return n * Factorial(n - 1);
        }

        static void FindFactorial()
        {
            Console.Write("Find Factorial of: ");
            int u = int.Parse(Console.ReadLine());
            Console.WriteLine("Factorial of " + u + " : "+Factorial(u));
        }

        static void TempConvert()
        {
            Console.Write("Enter Celcius: ");
            double celcius = double.Parse(Console.ReadLine());

            Console.WriteLine("Farenheit: " + Math.Round(((celcius - 32) * 5 / 9),2));
        }

        static void CurrencyConvert()
        {
            Console.Write("Enter Rupees: ");
            double rupees = double.Parse(Console.ReadLine());

            Console.WriteLine("USD: " + Math.Round((rupees / 84), 2));
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Available Options Select by Number\n1. Factorial\n2. Currency Convert\n3. Temperature Converter");
            Console.Write("Select a option: ");
            int selectedValue = int.Parse(Console.ReadLine());
            switch (selectedValuec)
            {
                case 1:
                    FindFactorial();
                    break;
                case 2:
                    CurrencyConvert();
                    break;
                case 3:
                    TempConvert(); 
                    break;
            }
            Console.ReadKey();
        }
    }
}
