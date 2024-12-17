using System;
using System.Linq;

namespace Positive_Num_Digit_Count;

public static class Program
{
    public static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int count = 0;

        if (a < 0)
        {
            Console.WriteLine("WARNING: Enter a positive number");
        }
        else
        {
            while (a != 0)
            {
                a = a / 10;
                count++;
            }
            Console.WriteLine($"Digit Count: {count}");
        }

    }
}
