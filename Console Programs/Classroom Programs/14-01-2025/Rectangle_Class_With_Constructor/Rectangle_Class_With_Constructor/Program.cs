using System;
using System.Linq;
using Rectangle_Class_With_Constructor;

namespace Rectangle_Class_With_Constructor
{

    public class Rectangle
    {
        int length, breadth;

        public Rectangle()
        {
            length = 10;
            breadth = 20;
        }

        public int calcArea()
        {
            return length * breadth;
        }
    }

    public static class Program
    {
        public static void Main()
        {

            Rectangle r1 = new Rectangle();

            Console.WriteLine(r1.calcArea());

        }
    }

}