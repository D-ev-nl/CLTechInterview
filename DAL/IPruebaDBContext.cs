using Microsoft.EntityFrameworkCore;
using Models;

namespace DAL
{
    public interface IPruebaDBContext
    {
        DbSet<Product> Products { get; set; }
        DbSet<ProductType> ProductTypes { get; set; }
        DbSet<ProductCategory> ProductCategories { get; set; }

        Task<int> SaveChangesAsync();
    }
}
