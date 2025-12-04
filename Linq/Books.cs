using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksLinq
{
    class Book
    {
        private string book_name, author;
        private int publication_year;
        
        public Book(string book_name, string author, int publication_year)
        {
            this.book_name = book_name;
            this.author = author;
            this.publication_year = publication_year;
        }

        public string Book_name { get { return book_name; } }
        public string Author { get { return author; } }
        public int Publication_year { get { return publication_year; } }

        public void BookOutput()
        {
            Console.WriteLine(book_name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var year = DateTime.Now.Year;

            List<Book> booksList = new List<Book>()
            {
                new Book("Harry Potter and the Chamber of Secrets", "J.K. Rowling", 1998),
                new Book("Harry Potter and the Goblet of Fire", "J.K. Rowling", 2000),
                new Book("Harry Potter and the Deathly Hallows", "J.K. Rowling", 2007),
                new Book("Fahrenheit 451", "Ray Bradbury", 1953),
                new Book("The Titan's curse", "Rick Riordan", 2007),
                new Book("The Sea of Monsters", "Rick Riordan", 2006),
                new Book("Ramsay in 10: Delicious Recipes Made in a Flash", "Gordon Ramsay", 2021)
            };

            var booksByRowling = from book in booksList
                                 where book.Author == "J.K. Rowling"
                                 select book;

            var titleWithFahrenheit = from book in booksList
                                      where book.Book_name.Contains("Fahrenheit")
                                      select book;

            var booksLastFiveYears = from book in booksList
                                     where book.Publication_year >= year - 5
                                     select book;

            Console.WriteLine("Books by J.K. Rowling :");
            foreach (var book in booksByRowling)
                book.BookOutput();

            Console.WriteLine("Books with Fahrenheit in title: ");
            foreach (var book in titleWithFahrenheit)
                book.BookOutput();

            Console.WriteLine("Books from last 5 years: ");
            foreach (var book in booksLastFiveYears)
                book.BookOutput();
        }
    }
}
