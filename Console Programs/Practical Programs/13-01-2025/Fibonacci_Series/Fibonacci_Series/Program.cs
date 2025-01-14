using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Series
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number of Terms: ");
            int noOfTerms = int.Parse(Console.ReadLine());

            Console.WriteLine();

            int a = 0, b = 1;
            Console.Write(a + " ");
            Console.Write(b + " ");

            for (int c = 2; c < noOfTerms; c++)
            {
                int temp = b;
                b = a + b;
                a = temp;

                Console.Write(b + " ");
            }

            Console.WriteLine();
        }
    }
}
