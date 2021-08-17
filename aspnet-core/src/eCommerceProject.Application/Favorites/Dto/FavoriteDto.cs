﻿using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using eCommerceProject.DbModels;
using eCommerceProject.ProductBrands.Dto;
using eCommerceProject.ProductColors.Dto;
using eCommerceProject.ProductTypes.Dto;

namespace eCommerceProject.Favorites.Dto
{
    [AutoMapFrom(typeof(Favorite))]
    [AutoMapTo(typeof(Favorite))]
    public class FavoriteDto : EntityDto<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
        public decimal ShipmentPrice { get; set; }

        public int ProductTypeId { get; set; }
        public ProductTypeDto ProductTypeFk { get; set; }

        public int ProductBrandId { get; set; }
        public ProductBrandDto ProductBrandFk { get; set; }

        public int ProductColorId { get; set; }
        public ProductColorDto ProductColorFk { get; set; }
    }
}
