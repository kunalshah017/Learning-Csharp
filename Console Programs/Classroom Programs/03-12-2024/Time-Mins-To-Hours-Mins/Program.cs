using System;

namespace TimeMinsToHoursMins
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Minutes: ");
            int min = int.Parse(Console.ReadLine());

            int hours = Convert.ToInt32( min / 60 );

            min = Convert.ToInt32( min % 60 );

            Console.WriteLine( hours + "hrs : " + min +"mins");
        }
    }
}