using System.ComponentModel.DataAnnotations;
namespace RazorMovies.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Genre { get; set; }
        public string? Rating { get; set; }
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        // public string? Duration { get; set; }
        // public string? Language { get; set; }
        // public string? Country { get; set; }
        // public string? Cast { get; set; }
        // public string? Director { get; set; }
        // public string? Description { get; set; }
        // public string? ImageUrl { get; set; }
        // public string? TrailerUrl { get; set; }
    }
}