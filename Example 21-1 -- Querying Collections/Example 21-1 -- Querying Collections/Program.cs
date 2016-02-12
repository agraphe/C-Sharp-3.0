using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example_21_1____Querying_Collections
{
    // simple book class
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public int PublicationYear { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Book> bookList = new List<Book>
            {
                new Book { Title = "Learning C# 3.0",
                           Author = "Jesse Liberty",
                           Publisher = "O'Reilly",
                           PublicationYear = 2008 },
                new Book { Title = "Programming C# 3.0",
                           Author = "Jesse Liberty",
                           Publisher = "O'Reilly",
                           PublicationYear = 2008 },
                new Book { Title = "C# 3.0 Cookbook",
                           Author = "Jay Hilyard",
                           Publisher = "O'Reilly",
                           PublicationYear = 2007 },
                new Book { Title = "C# 3.0 in a Nutshell",
                           Author = "Ben Albahari",
                           Publisher = "O'Reilly",
                           PublicationYear = 2007 },
                new Book { Title = "Head First C#",
                           Author = "Andrew Stellman",
                           Publisher = "O'Reilly",
                           PublicationYear = 2007 },
                new Book { Title = "Programming C#, fourth edition",
                           Author = "Jesse Liberty",
                           Publisher = "O'Reilly",
                           PublicationYear = 2005 }
            };

            // find books by Jesse Liberty
            IEnumerable<Book> resultsAuthor =
                from testBook in bookList
                where testBook.Author == "Jesse Liberty"
                select testBook;

            Console.WriteLine("Books by Jesse Liberty:");
            foreach (Book testBook in resultsAuthor)
            {
                Console.WriteLine("{0}, by {1}", testBook.Title, testBook.Author);
            }

            // find books published before 2008
            IEnumerable<Book> resultsDate =
                from testBook in bookList
                where testBook.PublicationYear < 2008
                select testBook;
            
            Console.WriteLine("\nBooks published before 2008:");
            foreach (Book testBook in resultsDate)
            {
                Console.WriteLine("{0}, by {1}, {2}", testBook.Title, testBook.Author, testBook.PublicationYear);
            }


        }
    }
}
