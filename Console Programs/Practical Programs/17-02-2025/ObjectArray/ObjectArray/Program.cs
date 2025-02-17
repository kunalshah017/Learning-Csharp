using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ObjectArray
{
    public class TextBook
    {
        string BookName, AuthorName;
        double BookPrice;

        public void getDataMembers(string BookName,string AuthorName, double BookPrice)
        {
            this.BookName = BookName;
            this.AuthorName = AuthorName;
            this.BookPrice = BookPrice;
        }

        public void printData()
        {
            Console.WriteLine(BookName + " " + AuthorName + " " + BookPrice);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Object Array
            Console.WriteLine("Enter info of 5 books: ");
            Console.WriteLine();
            TextBook[] b = new TextBook[5];

            for(int i  = 0; i < b.Length; i++)
            {
                b[i] = new TextBook();
                Console.Write("Enter name of the book: ");
                string bookName = Console.ReadLine();
                Console.Write("Enter Author name of the book: ");
                string authorName = Console.ReadLine();
                Console.Write("Enter price of the book: ");
                double price = Convert.ToDouble(Console.ReadLine());

                b[i].getDataMembers(bookName, authorName, price);
            }

            for(int i =0; i < b.Length;i++)
            {
                b[i].printData();
            }
        }
    }
}
