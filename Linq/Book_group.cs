using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLinq
{
    class Book
    {
        private string book_name, author, publisher;
        private int publication_year;

        public Book(string book_name, string author, string publisher, int publication_year)
        {
            this.book_name = book_name;
            this.author = author;
            this.publisher = publisher;
            this.publication_year = publication_year;
        }

        public string Book_name { get { return book_name; } }
        public string Author { get { return author; } }
        public string Publisher { get { return publisher; } }
        public int Publication_year { get { return publication_year; } }

        public void BookOutput()
        {
            Console.WriteLine(book_name);
        }
    }

    class Program
    {
        static List<Book> booksList;

        static int year = DateTime.Now.Year;

        static void FindByAuthor()
        {
            var booksByRowling = from book in booksList
                                 where book.Author == "J.K. Rowling"
                                 select book;

            Console.WriteLine("Books by J.K. Rowling :");
            foreach (var book in booksByRowling)
                book.BookOutput();
        }

        static void FindByPartTitle()
        {
            var titleWithFahrenheit = from book in booksList
                                      where book.Book_name.Contains("Fahrenheit")
                                      select book;

            Console.WriteLine("\nBooks with Fahrenheit in title: ");
            foreach (var book in titleWithFahrenheit)
                book.BookOutput();
        }

        static void FindPublishedLastFiveYears()
        {
            var booksLastFiveYears = from book in booksList
                                     where book.Publication_year >= year - 5
                                     select book;

            Console.WriteLine("\nBooks from last 5 years: ");
            foreach (var book in booksLastFiveYears)
                book.BookOutput();
        }

        static void FindLastPublishedBookByAuthor()
        {
            var books = from book in booksList
                        where book.Author == "J.K. Rowling" && book.Publication_year >= year - 20
                        select book;

            Console.WriteLine("\nBooks by J.K. Rowling from last 20 years: ");
            foreach (var book in books)
                book.BookOutput();
        }

        static void SortByAuthor()
        {
            var authors = from book in booksList
                          group book by book.Author
                          into author_group
                          orderby author_group.Key
                          select author_group;

            Console.WriteLine("\nAuthors sorted: ");
            foreach (var author in authors)
            {
                Console.WriteLine(author.Key);
            }

        }

        static void GroupPublisher()
        {
            var publisher_group = from book in booksList
                                  orderby book.Publisher, book.Author, book.Book_name
                                  group book by book.Publisher;

            foreach (var publisher in publisher_group)
            {
                Console.WriteLine("\nBooks published by " + publisher.Key + ": ");
                foreach (var book in publisher)
                {
                    Console.WriteLine(book.Author + " " + book.Book_name);
                }

            }
        }

        static void Main(string[] args)
        {
            booksList = new List<Book>()
            {
                new Book("Harry Potter and the Chamber of Secrets", "J.K. Rowling", "Bloomsbury", 1998),
                new Book("Harry Potter and the Goblet of Fire", "J.K. Rowling", "Bloomsbury", 2000),
                new Book("Harry Potter and the Deathly Hallows", "J.K. Rowling", "Bloomsbury", 2007),
                new Book("Fahrenheit 451", "Ray Bradbury", "Ballantine Books", 1953),
                new Book("The Titan's curse", "Rick Riordan", "Disney Hyperion", 2007),
                new Book("The Sea of Monsters", "Rick Riordan", "Disney Hyperion", 2006),
                new Book("Ramsay in 10: Delicious Recipes Made in a Flash", "Gordon Ramsay", "Hodder & Stoughton", 2021)
            };

            FindByAuthor();
            FindByPartTitle();
            FindPublishedLastFiveYears();
            FindLastPublishedBookByAuthor();
            SortByAuthor();
            GroupPublisher();
        }
    }
}
