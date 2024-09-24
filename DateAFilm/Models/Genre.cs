using System;
namespace DateAFilm.Models{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Navigation property to associate genres with films
        public ICollection<Film> Films { get; set; } = new List<Film>();
    }
}
