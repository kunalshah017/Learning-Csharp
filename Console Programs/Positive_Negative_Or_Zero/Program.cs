using System;

namespace Positive_Negative_Or_Zero;

public static class Program
{
    public static void Main()
    {
        Console.Write("Enter a Number : ");
        int u = int.Parse(Console.ReadLine());

        if (u < 0)
        {
            Console.WriteLine("{0} is Negative", u);
        }
        else if (u > 0)
        {
            Console.WriteLine("{0} is Positive", u);
        }
        else if (u == 0)
        {
            Console.WriteLine("{0} is Zero", u);
        }
    }
}
