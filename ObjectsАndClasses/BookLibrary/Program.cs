using System;
using System.Collections.Generic;
using System.Linq;

namespace BookLibrary
{
    class Program
    {
        static void Main()
        {
            int numberOfBooks = int.Parse(Console.ReadLine());
            Library library = new Library();
            library.Books = new List<Book>();
            library.Name = "Tihomir's library";

            for (int i = 0; i < numberOfBooks; i++)
            {
                Book book = new Book();
                string[] inputBooks = Console.ReadLine().Split().ToArray();
                book.Title = inputBooks[0];
                book.Autor = inputBooks[1];
                book.Publisher = inputBooks[2];
                book.ReleaseDate = inputBooks[3];
                book.ISBNNumber = inputBooks[4];
                book.Price =decimal.Parse( inputBooks[5]);
                library.Books.Add(book);
            }
            var filteredBooks = library.Books.Select(b => new
            {
                Author = b.Autor,
                EarningsTotal = library.Books.Where(b1 => b1.Autor.Equals(b.Autor))
                  .Sum(b1 => b1.Price)
            })
            .Distinct()
            .OrderByDescending(b => b.EarningsTotal)
            .ThenBy(b => b.Author)
            .ToList();
           
            foreach (var item in filteredBooks)
            {
                Console.WriteLine("{0:f2} -> {1:f2}",item.Author,item.EarningsTotal);
            }
        }
    }
    class Book
    {
        public string Title { get; set; }
        public string Autor { get; set; }
        public string Publisher { get; set; }
        public string ReleaseDate { get; set; }
        public string ISBNNumber { get; set; }
        public decimal Price { get; set; }
    }
    class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }
}
