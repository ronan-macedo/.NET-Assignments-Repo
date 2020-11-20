using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "The Other Side of Heaven",
                        ReleaseDate = DateTime.Parse("2003-4-1"),
                        Genre = "Romance",
                        Rating = "G",
                        Price = 18.86M,
                        ImagePath = null
                    },

                    new Movie
                    {
                        Title = "Baptists at Our Barbecue",
                        ReleaseDate = DateTime.Parse("2005-1-1"),
                        Genre = "Comedy",
                        Rating = "G",
                        Price = 24.65M,
                        ImagePath = null
                    },

                    new Movie
                    {
                        Title = "The Best Two Years",
                        ReleaseDate = DateTime.Parse("2004-9-7"),
                        Genre = "Comedy",
                        Rating = "G",
                        Price = 9.99M,
                        ImagePath = null
                    },

                    new Movie
                    {
                        Title = "Saints and Soldiers",
                        ReleaseDate = DateTime.Parse("2005-5-31"),
                        Genre = "Action",
                        Rating = "G",
                        Price = 8.99M,
                        ImagePath = null
                    }
                );
                context.SaveChanges();
            }
        }
    }
}