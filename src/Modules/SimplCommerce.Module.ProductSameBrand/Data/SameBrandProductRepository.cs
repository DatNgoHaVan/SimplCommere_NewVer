using System.Linq;
using SimplCommerce.Module.Catalog.Models;
using SimplCommerce.Module.Core.Data;
using SimplCommerce.Module.ProductSameBrand.Models;

namespace SimplCommerce.Module.ProductSameBrand.Data
{
  public class SameBrandProductRepository : Repository<Product>, ISameBrandProductRepository
  {
    private const long EntityViewedActivityTypeId = 1;
    private const long ProductEntityTypeId = 3;

    public SameBrandProductRepository(SimplDbContext context) : base(context)
    {
    }

    public IQueryable<Product> GetSameBrandProduct(long productId)
    {
      return from product in DbSet
             join e in Context.Set<SameBrandProduct>() on product.brandId equals e.brandId
             where e.productId == productId
             //orderby e.LatestViewedOn descending
             select product;
    }
  }
}