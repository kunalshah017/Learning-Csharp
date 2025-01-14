using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perfect_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number: ");
            int u = int.Parse(Console.ReadLine());
            int sum = 1;

            for (int i = 2; i < u; i++)
            {
                if (u % i == 0)
                {
                    sum = sum + i;
                }
            }

            Console.WriteLine();

            if (u == sum)
            {
                Console.WriteLine(u + " is a perfect number");
            }
            else
            {
                Console.WriteLine(u + " is not a perfect number");
            }
        }
    }
}
