using Microsoft.EntityFrameworkCore;
using Pustok.Mvc2.Models;

namespace Pustok.Mvc2.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Slider> Sliders { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<BookImage> BookImages { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<BookTag> BookTags { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        base.OnModelCreating(modelBuilder);
    }
}
