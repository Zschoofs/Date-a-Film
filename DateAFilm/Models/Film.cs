using System;
using System.ComponentModel.DataAnnotations; // For validation attributes
using System.ComponentModel.DataAnnotations.Schema; // For database-specific annotations

namespace DateAFilm.Models
{
    public class Film
    {
        // Primary Key
        public int Id { get; set; }

        // Title of the film
        [Required] // This ensures the title is required (not nullable in the database)
        [StringLength(50)] // Sets a max length for the title
        public string Title { get; set; }

        // Release year of the film
        [Required]
        [Range(1900, 2100, ErrorMessage = "Year must be between 1900 and 2100")] // Validates the range for the year
        public int Year { get; set; }

        // Genre of the film
        public ICollection<Genre> Genres { get; set; } = new List<Genre>();

        // Director(s) of the film
        public ICollection<Producer> Producers { get; set; } = new List<Producer>();

        // Description of the film
        [StringLength(500)]
        public string Description { get; set; }

        public string ImageUrl { get; set; }

        /* Ideas : date of watching, imbd notes, personal note, seen or not, */ 
    }
}
