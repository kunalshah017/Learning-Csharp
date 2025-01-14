using System;
using System.Linq;

namespace Sum_Avg_in_Array;

public static class Program
{
    public static void Main()
    {
        int[] arr1 = new int[5];
        int sum = 0;


        for (int c = 0; c < 5; c++)
        {
            Console.WriteLine($"Enter number at index {c}: ");
            arr1[c] = int.Parse(Console.ReadLine());

            sum = sum + arr1[c];
        }

        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Avg: {sum / 5}");
    }
}
