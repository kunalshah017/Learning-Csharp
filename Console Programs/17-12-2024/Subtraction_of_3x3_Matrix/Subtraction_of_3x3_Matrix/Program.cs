using System;
using System.Linq;

namespace Subtraction_of_3x3_Matrix;

public static class Program
{
    public static void Main()
    {

        int[,] mat1 = new int[3, 3];
        int[,] mat2 = new int[3, 3];

        for (int r = 0; r < 3; r++)
        {
            for (int c = 0; c < 3; c++)
            {
                mat1[r, c] = int.Parse(Console.ReadLine());
            }
        }

        for (int r = 0; r < 3; r++)
        {
            for (int c = 0; c < 3; c++)
            {
                mat2[r, c] = int.Parse(Console.ReadLine());
            }
        }

        for (int r = 0; r < 3; r++)
        {
            for (int c = 0; c < 3; c++)
            {
                Console.Write(mat1[r, c] + " ");
            }

            Console.Write(r == 1 ? "-" : " ");


            for (int c = 0; c < 3; c++)
            {
                Console.Write(mat2[r, c] + " ");
            }

            Console.Write(r == 1 ? "=" : " ");


            for (int c = 0; c < 3; c++)
            {
                int result = mat1[r, c] - mat2[r, c];
                Console.Write(result + " ");
            }

            Console.WriteLine();
        }

    }
}
