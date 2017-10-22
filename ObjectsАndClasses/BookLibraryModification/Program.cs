using System;
using System.Collections.Generic;
using System.Linq;

namespace BookLibraryModification
{
    class Program
    {
        static void Main()
        {
            int numberOfBooks = int.Parse(Console.ReadLine());
            Library library = new Library("My Library");

            for (int i = 0; i < numberOfBooks; i++)
            {
                string[] inputLine = Console.ReadLine().Split();

                string title = inputLine[0];
                string author = inputLine[1];
                string publisher = inputLine[2];
                DateTime releaseDate = DateTime.Parse(inputLine[3]);
                string isbn = inputLine[4];
                decimal price = decimal.Parse( inputLine[5]);

                Book book = new Book(title,author,publisher,releaseDate,isbn,price);
                library.Books.Add(book);
            }
            string endDate = "30.07.1954";
            DateTime targetReleasedDate = DateTime.Parse(endDate);
            Dictionary<string, List<Book>> booksByTitle = CreateBookByTitle(library);
            foreach (var item in booksByTitle.OrderBy(a => a.Value.Select(x => x.ReleaseDate)
                        .Where(x => x > targetReleasedDate)).ThenBy(a => a.Key).Distinct())
            {
                
                Console.WriteLine("{0}",item.Key);
                Console.WriteLine(string.Join(" ",item.Value.Select(x=>x.ReleaseDate)));
            }


        }
        private static Dictionary<string, List<Book>> CreateBookByTitle(Library library)
        {
            Dictionary<string, List<Book>> bookByAuthors = new Dictionary<string, List<Book>>();

            foreach (var book in library.Books)
            {
                if (!bookByAuthors.ContainsKey(book.Title))
                {
                    
                    bookByAuthors.Add(book.Title, new List<Book>());
                }
                bookByAuthors[book.Title].Add(book);
            }
            return bookByAuthors;
        }
    }
    class Book
    {
        public Book( string title, string author, string publisher, DateTime releaseDate, string isbn, decimal price)
        {
            this.Title = title;
            this.Author = author;
            this.Publisher = publisher;
            this.ReleaseDate = releaseDate;
            this.ISBN = isbn;
            this.Price = price;
        }

        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ISBN { get; set; }
        public decimal Price { get; set; }
    }
    class Library
    {
        public Library(string name)
        {
            this.Name = name;
            this.Books = new List<Book>();
        }

        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }
}
