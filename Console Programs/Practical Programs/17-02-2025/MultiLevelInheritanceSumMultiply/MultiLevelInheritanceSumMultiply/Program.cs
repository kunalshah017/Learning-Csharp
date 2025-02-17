using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLevelInheritanceSumMultiply
{
    public class Numbers
    {
        public int num1, num2;

        public Numbers(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }
    }

    public class Addition : Numbers {
        public Addition(int num1, int num2) : base(num1, num2) { }

        public void sum()
        {
            Console.WriteLine(num1 + num2);
        }

    }

    public class Multiplication : Addition
    {
        public Multiplication(int num1, int num2): base(num1, num2) { }

        public void multiply()
        {
            Console.WriteLine(num1 * num2); 
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Multiplication obj = new Multiplication(3, 5);
            obj.sum();

            obj.multiply();
        }
    }
}
