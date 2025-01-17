using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Level_Inheritence
{
    class Number
    {
        public int num1, num2;

        public void getNum(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }
    }

    class Add : Number
    {
        public int addition()
        {
            return num1 + num2;
        }
    }

    class Multiply : Add
    {
        public int multiplication()
        {
            return num1 * num2;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Multiply obj = new Multiply();

            obj.getNum(10, 20);

            Console.WriteLine("Addition: " + obj.addition());
            Console.WriteLine("Multiplication: " + obj.multiplication());
        }
    }
}
