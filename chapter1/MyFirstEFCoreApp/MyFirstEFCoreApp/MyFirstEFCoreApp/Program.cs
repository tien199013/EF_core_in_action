using System;
using Microsoft.EntityFrameworkCore;

namespace MyFirstEFCoreApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static void ListAll()
        {
            using (var db = new AppDbContext())
            {
                foreach (var book in db.Books.AsNoTracking().Include(a => a.Author))
                {
                    var webUrl = book.Author.WebUrl == null
                        ? "- no web URL givern -"
                        : book.Author.WebUrl;

                    Console.WriteLine($"{book.Title} by {book.Author.Name}");
                    Console.WriteLine($"\tPublished on {book.PublishedOn:dd-MMM-yyyy}. {webUrl}");
                }
            }
        }
    }
}
