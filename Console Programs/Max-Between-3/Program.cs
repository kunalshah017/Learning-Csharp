using System;

namespace Max_Between_3;

public static class Program
{
    public static void Main()
    {
        Console.Write("Enter 1st Number : ");
        int n1 = int.Parse(Console.ReadLine());

        Console.Write("Enter 2nd Number : ");
        int n2 = int.Parse(Console.ReadLine());

        Console.Write("Enter 3rd Number : ");
        int n3 = int.Parse(Console.ReadLine());

        if (n1 > n2)
        {
            if (n1 > n3)
            {
                Console.WriteLine($"{n1} is greatest");
            }
            else
            {
                Console.WriteLine($"{n3} is greatest");
            }
        }
        else
        {
            if (n2 > n3)
            {
                Console.WriteLine($"{n2} is greatest");
            }
            else
            {
                Console.WriteLine($"{n3} is greatest");
            }

        }
    }
}

