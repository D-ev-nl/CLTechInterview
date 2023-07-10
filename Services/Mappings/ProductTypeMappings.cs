using AutoMapper;
using Models;
using Services.DTOs.Product;
using Services.DTOs.ProductType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Mappings
{
    public class ProductTypeMappings : Profile
    {
        public ProductTypeMappings()
        {
            CreateMap<ProductType, ProductTypeDTO>();
        }
    }
}
