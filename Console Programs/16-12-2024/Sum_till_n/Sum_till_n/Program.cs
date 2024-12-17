using System;
using System.Linq;

namespace Sum_till_n;

public static class Program
{
    public static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int sum = 0;

        for (int c = 0; c <= a; c++)
        {
            sum = sum + a;
        }

        Console.Write($"Sum till {a} = {sum}");
    }
}
