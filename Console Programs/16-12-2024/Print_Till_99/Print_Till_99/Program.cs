using System;
using System.Linq;

namespace Print_Till_99;

public static class Program
{
    public static void Main()
    {
        int u = 99;
        do
        {
            u = int.Parse(Console.ReadLine());
            Console.WriteLine(u);
        } while (u != 99);

    }
}
