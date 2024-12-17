using System;
using System.Linq;

namespace Num_Pattern;

public static class Program
{
    public static void Main()
    {
        int count = 1;

        for (int c = 0; c < 4; c++)
        {
            for (int c1 = 0; c1 <= c; c1++)
            {
                Console.Write(" ");
                Console.Write(count);
                count++;
            }
            Console.WriteLine();
        }

    }
}
