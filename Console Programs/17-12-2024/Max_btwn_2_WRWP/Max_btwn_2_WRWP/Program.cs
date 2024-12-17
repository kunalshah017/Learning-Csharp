using System;
using System.Linq;
using Max_btwn_2_WRWP;

namespace Max_btwn_2_WRWP;

public class Program
{
    public static void Main()
    {
        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());

        Program p = new Program();
        Console.WriteLine("Max: " + p.MaxBtwn2(n1, n2));


    }

    public int MaxBtwn2(int a, int b)
    {
        if (a > b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }
}
