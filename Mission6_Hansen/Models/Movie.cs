using System.ComponentModel.DataAnnotations;

namespace Mission6_Hansen.Models
{
    public class Movie
    {
        [Key]
        [Required]
        public int MovieID { get; set; }
        public string Category { get; set; }

        public string Title { get; set; }

        public int Year { get; set; }

        public string Director { get; set; }

        public string Rating { get; set; }

        public string? Edit { get; set; }

        public string? Lent { get; set; }

        public string? Notes { get; set; }
    }
}
