using System;
using System.Linq;

namespace Days_with_Switch;

public static class Program
{
    public static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        switch (a)
        {
            case 1:
                Console.WriteLine("Sunday");
                break;
            case 2:
                Console.WriteLine("Monday");
                break;
            case 3:
                Console.WriteLine("Tuesday");
                break;
            case 4:
                Console.WriteLine("Wednesday");
                break;
            case 5:
                Console.WriteLine("Thursdau");
                break;
            case 6:
                Console.WriteLine("Friday");
                break;
            case 7:
                Console.WriteLine("Saturday");
                break;
            default:
                Console.WriteLine("Enter a number between 1 to 7");
                break;
        }
    }
}