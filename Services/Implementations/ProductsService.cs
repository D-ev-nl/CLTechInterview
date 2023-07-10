using AutoMapper;
using AutoMapper.QueryableExtensions;
using DAL;
using Microsoft.EntityFrameworkCore;
using Models;
using Services.DTOs.Product;
using Services.Interfacces;

namespace Services.Implementations
{
    public class ProductsService : IProductsService
    {
        private readonly IPruebaDBContext _pruebaDBContext;
        private readonly IMapper _mapper;
        public ProductsService(IPruebaDBContext pruebaDBContext, IMapper mapper)
        {
            _pruebaDBContext = pruebaDBContext;
            _mapper = mapper;
        }

        public async Task<ProductDTO> Create(ProductDTO dto)
        {
            if (dto == null) throw new ArgumentNullException(nameof(dto));

            var newEntity = new Product()
            {
                Name = dto.Name,
                Description = dto.Description,
                Type = await _pruebaDBContext.ProductTypes.FindAsync(dto.TypeId),
                Category = await _pruebaDBContext.ProductCategories.FindAsync(dto.CategoryId),
            };

            var entity = _pruebaDBContext.Products.Add(newEntity);
            await _pruebaDBContext.SaveChangesAsync();

            return _mapper.Map<ProductDTO>(entity.Entity);
        }

        public async Task Delete(long id)
        {
            var entity = await _pruebaDBContext.Products.FindAsync(id);
            _pruebaDBContext.Products.Remove(entity);
            await _pruebaDBContext.SaveChangesAsync();
        }

        public Task<bool> Exists(long id)
        {
            return _pruebaDBContext.Products.AnyAsync(x => x.Id == id);
        }

        public async Task<ProductDTO> Get(long id)
        {
            var entity = await _pruebaDBContext.Products.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
            return _mapper.Map<ProductDTO>(entity);
        }

        public Task<List<ProductGridItemDTO>> GetAll()
        {
            return _pruebaDBContext.Products
                .ProjectTo<ProductGridItemDTO>(_mapper.ConfigurationProvider)
                .ToListAsync();
        }

        public Task<List<ProductItemDTO>> ListAll()
        {
            return _pruebaDBContext.Products
                .ProjectTo<ProductItemDTO>(_mapper.ConfigurationProvider)
                .ToListAsync();
        }

        public async Task<ProductDTO> Update(long id, ProductDTO dto)
        {
            if (dto == null) throw new ArgumentNullException(nameof(dto));

            var entity = await _pruebaDBContext.Products.FindAsync(id);
            entity.Description = dto.Description;
            entity.Name = dto.Name;
            entity.CategoryId= dto.CategoryId;
            entity.TypeId= dto.TypeId;
            await _pruebaDBContext.SaveChangesAsync();

            return _mapper.Map<ProductDTO>(entity);
        }

        public Task<(bool Valid, string Message)> Validate(long? id, ProductDTO dto)
        {
            return Task.FromResult((true, string.Empty));
        }
    }
}