using System;
using System.Linq;

namespace Rectangle_area_perimeter_with_out;

public static class Program
{
    public static void calculate(int length, int breadth, out int area, out int perimeter)
    {
        area = length * breadth;
        perimeter = 2 * (length + breadth);
    }

    public static void Main()
    {
        int length = int.Parse(Console.ReadLine());
        int breadth = int.Parse(Console.ReadLine());

        int areaResult, perimeterResult;

        calculate(length, breadth, out areaResult, out perimeterResult);

        Console.WriteLine("Area :" + areaResult);
        Console.WriteLine("Perimeter :" + perimeterResult);

    }
}
