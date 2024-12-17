using System;

namespace VariableSwapping
{
    class Program {
        static void Main(string[] args)
        {
            Console.Write("Enter a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter b: ");
            int b = int.Parse(Console.ReadLine());

            int temp = b;
            b = a;
            a = temp;

            Console.WriteLine("Swapped Variables a: " + a + " b: " + b);



            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("Swapped Variables without temp - a: " + a + " b: " + b);
        }
    }
}