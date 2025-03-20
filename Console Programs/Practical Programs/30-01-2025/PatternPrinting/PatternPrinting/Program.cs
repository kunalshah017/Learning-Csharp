using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternPrinting
{
    class Program
    {
        static void PrintPattern1(int rows)
        {
            int c = 1;

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(c + " ");
                    c++;
                }
                Console.WriteLine();
            }
        }

        static void PrintPattern2(int rows)
        {
            int c = 1;
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (c % 2 != 0)
                    {
                        Console.Write("1 ");
                    }
                    else
                    {
                        Console.Write("0 ");
                    }
                }

                Console.WriteLine();
            }
        }

        static void PrintPattern3(int rows)
        {
            for (int i = 1; i <= rows; i++)
            {
                for (int s = rows - i; s >= 0; s--)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Enter the number of rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nPattern 1\n\n");
            PrintPattern1(rows);

            Console.WriteLine("\nPattern 2\n\n");
            PrintPattern2(rows);

            Console.WriteLine("\nPattern 3\n\n");
            PrintPattern3(rows);
        }
    }
}
