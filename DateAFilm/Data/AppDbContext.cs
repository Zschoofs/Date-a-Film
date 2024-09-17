using Microsoft.EntityFrameworkCore;

// Class that allow Entity framework to handle intereactions with the database

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    // Ajouter DbSet pour chaque modèle
    public DbSet<Product> Products { get; set; }
}
