using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeHousePracticeSessions.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            var film = new Movie("Snakes on a Plane", "David R Ellis");
            var book = new Book("Sharpes Tiger", "Bernard Cornwell");

            Console.WriteLine($" 1. Movie- Title: {film.Title}, Director: {film.Director}");
            Console.WriteLine($"Book- Title: {book.Title}, Author: {book.Author}");

            book.GetDisplayText("Sharpes Tiger", "Bernard Cornwell");
            film.GetDisplayText("Snakes on a Plane", "David R Ellis");

            Console.WriteLine(book.GetDisplayText("Sharpes Tiger", "Bernard Cornwell"));
            Console.WriteLine(film.GetDisplayText("Snakes on a Plane", "David R Ellis"));


        }
    }
}
