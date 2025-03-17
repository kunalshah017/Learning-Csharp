
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Happy_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number: ");
            int u = int.Parse(Console.ReadLine());
            int check = u;

            Console.WriteLine();

            while (true)
            {
                int sum = 0;
                int temp = u;
                while (temp > 0)
                {
                    int digit = temp % 10;
                    sum = sum + (digit * digit);
                    temp = temp / 10;
                }

                if (sum == 1)
                {
                    Console.WriteLine(check + " is a Happy Number :)");
                    break;
                }
                else if (sum == 4)
                {
                    Console.WriteLine(check + " is not Happy Number :(");
                    break;
                }

                u = sum;
            }
        }

    }
}
