﻿using AutoMapper;
using Models;
using Services.DTOs.Product;
using Services.DTOs.ProductCategory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Mappings
{
    public class ProductCategoryMappings : Profile
    {
        public ProductCategoryMappings()
        {
            CreateMap<ProductCategory, ProductCategoryDTO>();
        }
    }
}
