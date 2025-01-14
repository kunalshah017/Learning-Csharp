using System;
using System.Linq;

namespace Count_Positive_Negative_in_Array;

public static class Program
{
    public static void Main()
    {
        int[] arr1 = new int[10];
        int pos = 0;
        int neg = 0;

        for (int c = 0; c < 10; c++)
        {
            Console.WriteLine($"Enter number at index {c}: ");
            arr1[c] = int.Parse(Console.ReadLine());

            if (arr1[c] > 0)
            {
                pos++;
            }
            else
            {
                neg++;
            }
        }

        Console.WriteLine($"Positive Count: {pos}");
        Console.WriteLine($"Negative Count: {neg}");
    }
}
