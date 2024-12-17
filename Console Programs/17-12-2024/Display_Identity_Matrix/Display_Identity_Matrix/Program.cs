using System;
using System.Linq;

namespace Display_Identity_Matrix;

public static class Program
{
    public static void Main()
    {

        for (int r = 0; r < 3; r++)
        {
            for (int c = 0; c < 3; c++)
            {
                Console.Write(r == c ? 1 : 0);
                Console.Write(" ");
            }
            Console.WriteLine();
        }

    }
}
