using System;
using Microsoft.EntityFrameworkCore;
using SimplCommerce.Infrastructure.Data;
using SimplCommerce.Module.Core.Models;

namespace SimplCommerce.Module.ProductSameBrand.Data
{
    public class ProductSameBrandCustomModelBuilder : ICustomModelBuilder
    {
        public void Build(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Widget>().HasData(
                new Widget("SameBrandWidget")
                {
                    Name = "Same Brand Widget",
                    ViewComponentName = "SameBrandWidget",
                    CreateUrl = "widget-same-brand-create",
                    EditUrl = "widget-same-brand-edit",
                    CreatedOn = new DateTimeOffset(new DateTime(2018, 5, 29, 4, 33, 39, 164, DateTimeKind.Unspecified),
                        new TimeSpan(0, 7, 0, 0, 0))
                }
            );
        }
    }
}