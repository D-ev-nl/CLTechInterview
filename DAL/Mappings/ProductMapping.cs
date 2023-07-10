using Microsoft.EntityFrameworkCore;
using Models;

namespace DAL.Mappings
{
    public static partial class ModelsMappings
    {
        public static ModelBuilder MapProduct(this ModelBuilder modelBuilder)
        {
            var entityBuilder = modelBuilder.Entity<Product>();

            entityBuilder.Property(x => x.Name).IsRequired();
            entityBuilder.Property(x => x.Description).IsRequired();
            //entityBuilder.HasOne(x => x.Type).WithOne();
            //entityBuilder.HasOne(x => x.Category).WithMany(x => x.Products);

            return modelBuilder;
        }
    }
}
