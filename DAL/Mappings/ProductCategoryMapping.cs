using Microsoft.EntityFrameworkCore;
using Models;

namespace DAL.Mappings
{
    public static partial class ModelsMappings
    {
        public static ModelBuilder MapProductCategory(this ModelBuilder modelBuilder)
        {
            var entityBuilder = modelBuilder.Entity<ProductCategory>();

            entityBuilder.Property(x => x.Name).IsRequired();
            entityBuilder.HasMany(x => x.Products).WithOne(x => x.Category);

            return modelBuilder;
        }
    }
}
