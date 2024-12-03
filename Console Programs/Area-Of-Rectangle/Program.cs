using System;

namespace RectangleArea
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of the rectangle: ");
            int length = int.Parse(Console.ReadLine());
            Console.Write("Enter the width of the rectangle: ");
            int width = int.Parse(Console.ReadLine());

            Console.WriteLine("The area of the rectangle is: " + (length * width));
        }
    }

}
