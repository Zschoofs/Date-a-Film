using System;
using System.ComponentModel.DataAnnotations; // For validation attributes
using System.ComponentModel.DataAnnotations.Schema;
using DateAFilm.Controllers; // For database-specific annotations

namespace DateAFilm.Models
{
    public class Producer
    {
        // Primary Key
        public int Id { get; set; }

        // Name of the producer
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        // Birth date of the producer
        [Range(1850, 2100, ErrorMessage = "Year must be between 1850 and 2100")] // Validates the range for the year
        public int BirthYear { get; set; }

        // Description of the producer
        [StringLength(500)]
        public string Description { get; set; }

        public List<Film> Films { get; set;}
    }
}
