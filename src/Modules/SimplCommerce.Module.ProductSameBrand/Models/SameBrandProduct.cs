using System;
using SimplCommerce.Infrastructure.Models;

namespace SimplCommerce.Module.ProductSameBrand.Models
{
    public class SameBrandProduct : EntityBase
    {
        long brandId {get; set;}

        long productId {get;set;}
    }
}