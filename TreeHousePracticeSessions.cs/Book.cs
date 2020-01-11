using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeHousePracticeSessions.cs
{
    class Book
    {
        public readonly string Author;
        public readonly string Title;


        public Book(string title, string author, Boolean onLoan)
        {
            Author = author;
            Title = title;
        }
        public string GetDisplayText(string author, string title)
        {
            Console.WriteLine($"Book- Title: {title}, Author: {author}");

            return $"Book- Title: {title}, Author: {author}";
        }

    }
}
