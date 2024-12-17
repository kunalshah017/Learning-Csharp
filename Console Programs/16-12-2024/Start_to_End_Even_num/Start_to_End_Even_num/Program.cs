using System;
using System.Linq;

namespace Start_to_End_Even_num;

public static class Program
{
    public static void Main()
    {
        Console.Write("Start: ");
        int start = int.Parse(Console.ReadLine());

        Console.Write("End: ");
        int end = int.Parse(Console.ReadLine());

        for (int i = start; i <= end; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
