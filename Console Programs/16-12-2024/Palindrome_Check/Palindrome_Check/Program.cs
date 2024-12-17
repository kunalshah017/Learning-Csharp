using System;
using System.Linq;

namespace Palindrome_Check;

public static class Program
{
    public static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int p = 0;
        int temp = a;

        while (temp != 0)
        {
            p = p * 10;

            p = p + (temp % 10);

            temp = temp / 10;
        }

        if (p == a)
        {
            Console.WriteLine($"{a} is palindrome");
        }
        else
        {
            Console.WriteLine($"{a} is not palindrome");
        }
    }
}
