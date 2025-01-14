using System;
using System.Linq;
using Class_and_Objects;

namespace Class_and_Objects;

public class Program
{
    public void sum(int a, int b)
    {
        Console.WriteLine((a + b));
    }

    public static void Main()
    {

        Program p = new Program();

        p.sum(2, 4);

    }
}
