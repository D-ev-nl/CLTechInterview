using Services.DTOs;
using Services.DTOs.Product;

namespace Services.Interfacces
{
    public interface IProductsService : IServiceInterface<ProductDTO, ProductItemDTO, ProductGridItemDTO, long>
    {

    }
}
