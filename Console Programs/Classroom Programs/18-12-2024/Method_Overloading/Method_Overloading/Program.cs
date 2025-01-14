using System;
using System.Linq;
using Method_Overloading;

namespace Method_Overloading;

public class Program
{
    public void add(int a, int b)
    {
        Console.WriteLine((a + b));
    }

    public void add(float a, float b)
    {
        Console.WriteLine((a + b));
    }

    public void add(String a, String b)
    {
        Console.WriteLine(a + b);
    }

    public static void Main()
    {
        int i1 = 10, i2 = 20;
        float f1 = 10.20f, f2 = 20.30f;
        String s1 = "hello", s2 = "world!";

        Program p = new Program();

        p.add(i1, i2);
        p.add(f1, f2);
        p.add(s1, s2);

    }
}
