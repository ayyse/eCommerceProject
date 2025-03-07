﻿using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using eCommerceProject.DbModels;

namespace eCommerceProject.ProductBrands.Dto
{
    [AutoMapFrom(typeof(ProductBrand))]
    [AutoMapTo(typeof(ProductBrand))]
    public class ProductBrandDto : EntityDto<int>
    {
        public string Name { get; set; }
    }
}
