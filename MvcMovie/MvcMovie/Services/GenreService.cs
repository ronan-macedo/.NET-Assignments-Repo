using MvcMovie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Services
{
    public class GenreService
    {
        public static List<Movie> GetGenres()
        {
            var listGenres = new List<Movie>()
            {
                new Movie() { Genre = "Comedy"},
                new Movie() { Genre = "Action"},
                new Movie() { Genre = "Adventure"},
                new Movie() { Genre = "Documentary"},
                new Movie() { Genre = "Romance"},
                new Movie() { Genre = "Drama"}                
            };

            return listGenres;
        }
    }
}
