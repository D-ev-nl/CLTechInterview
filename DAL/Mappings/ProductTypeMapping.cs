using Microsoft.EntityFrameworkCore;
using Models;

namespace DAL.Mappings
{
    public static partial class ModelsMappings
    {
        public static ModelBuilder MapProductType(this ModelBuilder modelBuilder)
        {
            var entityBuilder = modelBuilder.Entity<ProductType>();

            entityBuilder.Property(x => x.Name).IsRequired();

            return modelBuilder;
        }
    }
}
