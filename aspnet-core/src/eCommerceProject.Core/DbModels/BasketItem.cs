﻿using Abp.Domain.Entities;

namespace eCommerceProject.DbModels
{
    public class BasketItem : Entity<int>, IMayHaveTenant
    {
        public int? TenantId { get; set; }


        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
        public decimal ShipmentPrice { get; set; }
        public int Quantity { get; set; }


        public ProductType ProductTypeFk { get; set; }

        public ProductBrand ProductBrandFk { get; set; }

        public ProductColor ProductColorFk { get; set; }

    }
}
