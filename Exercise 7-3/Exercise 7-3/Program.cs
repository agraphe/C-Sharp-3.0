using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise_7_3
{
    class Book
    {
        private string title;
        private string author;
        private string publisher = "O'Reilly";
        private string isbn;

        public void OutputBook()
        {
            Console.WriteLine("Title: {0}, Author: {1}, Publisher: {2}, ISBN: {3}", title, author, publisher, isbn);
        }

        //constructor
        public Book(string myTitle, string myAuthor, string myIsbn)
        {
            title = myTitle;
            author = myAuthor;
            isbn = myIsbn;
        }
    }

    class Program
    {
        static void Main()
        {
            Book firstBook = new Book("Programming C# 3.0", "Jesse Liberty and Donald Xie", "9780596527433");
            Book secondBook = new Book("C# 3.0 In a Nutshell", "Joseph Albahari and Ben Albahari", "9780596527570");
            Book thirdBook = new Book("C# 3.0 Cookbook", "Jay Hilyard and Stephen Teilhet", "9780596516109");

            Console.WriteLine("First book:");
            firstBook.OutputBook();
            Console.WriteLine("Second book:");
            secondBook.OutputBook();
            Console.WriteLine("Third book:");
            thirdBook.OutputBook();
        }
    }
}
