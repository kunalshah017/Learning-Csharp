using System;
using System.Linq;
using Number_to_Power_with_out;

namespace Number_to_Power_with_out;

public class Program
{
    public void power(int baseVal, int powerVal, out int result)
    {
        result = 1;
        for (int c = 0; c < powerVal; c++)
        {
            result = result * baseVal;
        }
    }

    public static void Main()
    {
        int baseVal = int.Parse(Console.ReadLine());
        int powerVal = int.Parse(Console.ReadLine());
        int result;

        Program p = new Program();

        p.power(baseVal, powerVal, out result);

        Console.Write($"{baseVal}^{powerVal} = {result}");
    }
}
