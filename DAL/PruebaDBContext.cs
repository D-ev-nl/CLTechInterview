using DAL.Mappings;
using Microsoft.EntityFrameworkCore;
using Models;

namespace DAL
{
    public class PruebaDBContext : DbContext, IPruebaDBContext
    {
        public PruebaDBContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }

        public Task<int> SaveChangesAsync()
            => base.SaveChangesAsync();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.MapProduct();
            modelBuilder.MapProductType();
            modelBuilder.MapProductCategory();
        }
    }
}