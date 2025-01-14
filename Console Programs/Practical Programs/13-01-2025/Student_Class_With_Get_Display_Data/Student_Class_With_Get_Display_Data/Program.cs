using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Class_With_Get_Display_Data
{
    public class Student
    {
        int id;
        String name, course;
        double percentage;
        public void getData()
        {
            Console.Write("Enter Id: ");
            this.id = int.Parse(Console.ReadLine());

            Console.Write("Enter Name: ");
            this.name = Console.ReadLine();

            Console.Write("Enter Course: ");
            this.course = Console.ReadLine();

            Console.Write("Enter Percentage: ");
            this.percentage = double.Parse(Console.ReadLine());
        }

        public void displayData()
        {
            Console.WriteLine("\n\nId:" + this.id);
            Console.WriteLine("Name: " + this.name);
            Console.WriteLine("Course: " + this.course);
            Console.WriteLine("Percentage: " + this.percentage);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.getData();
            student1.displayData();
        }
    }
}
