using Microsoft.EntityFrameworkCore;
using RazorMovies.Data;
using RazorMovies.Models;
namespace RazorMovies.SeedData
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorMoviesContext(
                serviceProvider.GetRequiredService<DbContextOptions<RazorMoviesContext>>()))
            {
                if (context == null || context.Movie == null)
                {
                    throw new ArgumentNullException("Null RazorMoviesContext");
                }
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded  
                }
                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "The Shawshank Redemption",
                        Genre = "Drama",
                        ReleaseDate = DateTime.Parse("1994-9-23"),
                        Rating = "R"
                    },
                    new Movie
                    {
                        Title = "The Godfather",
                        Genre = "Crime",
                        ReleaseDate = DateTime.Parse("1972-3-24"),
                        Rating = "R"
                    },
                    new Movie
                    {
                        Title = "The Dark Knight",
                        Genre = "Action",
                        ReleaseDate = DateTime.Parse("2008-7-18"),
                        Rating = "PG-13"
                    }
                );
                context.SaveChanges();
            }
        }
    } 
}
