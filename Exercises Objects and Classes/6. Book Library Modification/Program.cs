using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _5._Book_Library
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            int numberOfBooks = int.Parse(Console.ReadLine());
            library.Books = new List<Book>();
            library.Name = "library";
            for (int i = 0; i < numberOfBooks; i++)
            {
                string[] book = Console.ReadLine().Split(' ');
                library.Books.Add(new Book(book[0], book[1], book[2]
                    , DateTime.ParseExact(book[3], "dd.MM.yyyy", CultureInfo.InvariantCulture)
                    , book[4], double.Parse(book[5])));
            }
            DateTime contrDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
            var authors = new Dictionary<string, DateTime>();
            foreach (var currentBook in library.Books)
            {
                if (currentBook.RealeseDate > contrDate)
                {
                    authors.Add(currentBook.Title , currentBook.RealeseDate);
                }
            }
            authors = authors.OrderBy(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            foreach (var author in authors)
            {
                Console.WriteLine($"{author.Key} -> {author.Value:dd.MM.yyyy}");
            }
        }
    }
    class Library
    {
        public string Name;
        public List<Book> Books;
    }
    class Book
    {
        public string Title;
        public string Author;
        public string Publosher;
        public DateTime RealeseDate;
        public string ISBN_Number;
        public double Price;
        public Book(string title, string author, string publisher, DateTime realeseDate, string isbn_number, double price)
        {
            Title = title;
            Author = author;
            Publosher = publisher;
            RealeseDate = realeseDate;
            ISBN_Number = isbn_number;
            Price = price;
        }
    }
}
