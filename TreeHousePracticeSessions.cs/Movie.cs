using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeHousePracticeSessions.cs
{
    class Movie
    {
        public  string Title;
        public  string Director;

        public Movie(string title, string director)
        {
            Title = title;
            Director = director;
        }
       
        public string GetDisplayText(string title, string director)
        {
             Console.WriteLine($"Movie- Title: {title}, Director: {director}");
            return $"Movie- Title: {title}, Director: {director}";
        }
    }
}

