using System;
using System.Linq;

namespace Krishnamurthy_Num;

public static class Program
{
    public static int Fact(int num)
    {
        if (num == 1)
        {
            return 1;
        }

        return num * Fact(num - 1);
    }

    public static void Main()
    {
        int sum = 0;

        Console.Write("Enter a number: ");
        int u = int.Parse(Console.ReadLine());
        int chk = u;

        while (u != 0)
        {
            int digit = u % 10;
            sum = sum + Fact(digit);
            u = u / 10;
        }

        if (chk == sum)
        {
            Console.Write($"{chk} is Krishnamurthy Number");
        }
        else
        {
            Console.Write($"{chk} is Not Krishnamurthy Number");
        }
    }
}
