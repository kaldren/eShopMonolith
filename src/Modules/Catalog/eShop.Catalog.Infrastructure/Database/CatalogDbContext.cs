using eShop.Catalog.Domain;
using Microsoft.EntityFrameworkCore;

namespace eShop.Catalog.Infrastructure.Database;
internal class CatalogDbContext : DbContext
{
    public CatalogDbContext(DbContextOptions<CatalogDbContext> options)
        : base(options)
    {
    }
    public DbSet<Product> Products { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Use Products schema
        modelBuilder.Entity<Product>()
            .ToTable("Products", "Products");
    }
}
