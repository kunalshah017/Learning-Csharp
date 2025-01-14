using System;

namespace String_Reverse;

public static class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a string : ");
        String myStr = Console.ReadLine();

        for (int c = myStr.Length - 1; c >= 0; c--)
        {
            Console.Write(myStr[c]);
        }
    }
}

