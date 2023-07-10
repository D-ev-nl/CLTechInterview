using AutoMapper;
using Models;
using Services.DTOs.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Mappings
{
    public class ProductMappings : Profile
    {
        public ProductMappings()
        {
            CreateMap<Product, ProductDTO>();
            CreateMap<Product, ProductItemDTO>();
            CreateMap<Product, ProductGridItemDTO>();
        }
    }
}
