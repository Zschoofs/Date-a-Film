using DateAFilm.Models;
using Microsoft.EntityFrameworkCore;

// Class that allow Entity framework to handle intereactions with the database

namespace DateAFilm.Data {
        
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // Adding each model in the DB
        public DbSet<Film> Films { get; set; }
        public DbSet<Producer> Producers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuring many-to-many relationship between Film and Producer
            modelBuilder.Entity<Film>()
                .HasMany(f => f.Producers)
                .WithMany(p => p.Films);
        }
    }

}