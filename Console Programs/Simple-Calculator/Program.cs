using System;

namespace Simple_Calculator;

public static class Program
{
    public static void Main()
    {

        Console.Write("Enter first number : ");
        int n1 = int.Parse(Console.ReadLine());

        Console.Write("Enter second number : ");
        int n2 = int.Parse(Console.ReadLine());

        Console.Write("Enter operator : ");
        String o = Console.ReadLine();

        if (o == "+")
        {
            Console.WriteLine("{0}+{1}={2}", n1, n2, n1 + n2);
        }
        else if (o == "-")
        {
            Console.WriteLine("{0}-{1}={2}", n1, n2, n1 - n2);
        }
        else if (o == "*")
        {
            Console.WriteLine("{0}*{1}={2}", n1, n2, n1 * n2);
        }
        else if (o == "/")
        {
            Console.WriteLine("{0}/{1}={2:F2}", n1, n2, (double)n1 / n2);
        }
        else
        {
            Console.WriteLine("Invalid Operator");
        }
    }
}

