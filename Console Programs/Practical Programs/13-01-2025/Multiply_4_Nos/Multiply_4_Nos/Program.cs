using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiply_4_Nos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 4 Numbers: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            Console.WriteLine($"\n{a} x {b} x {c} x {d} = " + a * b * c * d);
        }
    }
}
