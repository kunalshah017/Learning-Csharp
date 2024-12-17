using System;
using System.Linq;
using Reference_Variable;

namespace Reference_Variable;

public class Program
{
    public static void Main()
    {
        Program p = new Program();

        int a = int.Parse(Console.ReadLine());

        p.cube(ref a);

    }

    public void cube(ref int a)
    {
        Console.WriteLine("Cube :" + (a * a * a));
    }
}
