
using Microsoft.EntityFrameworkCore;
using Challenge2.Models;

namespace Challenge2.Persistence.Contexts
{
    public class AppDbContext : DbContext
    {
        public DbSet<ProductCategory> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ProductCategory>().ToTable("Categories");
            builder.Entity<ProductCategory>().HasKey(p => p.Id);
            builder.Entity<ProductCategory>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<ProductCategory>().Property(p => p.Name).IsRequired().HasMaxLength(30);
            builder.Entity<ProductCategory>().HasMany(p => p.Products).WithOne(p => p.Category).HasForeignKey(p => p.CategoryId);

            builder.Entity<ProductCategory>().HasData
            (
                new ProductCategory { Id = 100, Name = "Fruits and Vegetables" }, // Id set manually due to in-memory provider
                new ProductCategory { Id = 101, Name = "Dairy" }
            );

            builder.Entity<Product>().ToTable("Products");
            builder.Entity<Product>().HasKey(p => p.Id);
            builder.Entity<Product>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Product>().Property(p => p.Name).IsRequired().HasMaxLength(50);
            builder.Entity<Product>().Property(p => p.QuantityInPackage).IsRequired();
            builder.Entity<Product>().Property(p => p.UnitOfMeasurement).IsRequired();
        }
    }
}