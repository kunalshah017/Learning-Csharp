using System;
using System.Linq;

namespace Max_Min_from_Array;

public static class Program
{
    public static void Main()
    {
        int[] arr1 = new int[10];
        int min = 0;
        int max = 0;


        for (int c = 0; c < 10; c++)
        {
            Console.WriteLine($"Enter number at index {c}: ");
            arr1[c] = int.Parse(Console.ReadLine());
            if (c == 0)
            {
                min = arr1[c];
                max = arr1[c];
            }
            if (arr1[c] > max)
            {
                max = arr1[c];
            }
            if (arr1[c] < min)
            {
                min = arr1[c];
            }
        }

        Console.WriteLine($"Max: {max}");
        Console.WriteLine($"Min: {min}");
    }
}
