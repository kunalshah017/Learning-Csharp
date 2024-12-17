using System;
using System.Linq;

namespace For_Each_Loop;

public static class Program
{
    public static void Main()
    {
        String[] names = { "Aryan", "Kunal", "Aayush" };

        foreach (String i in names)
        {
            Console.WriteLine(i);
        }

    }
}
