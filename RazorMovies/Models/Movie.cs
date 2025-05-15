using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace RazorMovies.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }
        public string Rating { get; set; } = string.Empty;
        public string? Genre { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
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