using System;

namespace Even_Odd_Check;

public static class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a number : ");
        int u = int.Parse(Console.ReadLine());

        if (u % 2 == 0)
        {
            Console.WriteLine("{0} is a even number", u);
        }
        else
        {
            Console.WriteLine("{0} is a odd number", u);
        }
    }
}

