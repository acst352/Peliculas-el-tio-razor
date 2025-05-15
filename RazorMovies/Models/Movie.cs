using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace RazorMovies.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [StringLength(60, MinimumLength = 3)]
        public string? Title { get; set; } = string.Empty;
        [DataType(DataType.Date)]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(30)]
        public string? Genre { get; set; } = string.Empty;
        [Range(1,100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [Required]
        [StringLength(5)]
        public string Rating { get; set; } = string.Empty;
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