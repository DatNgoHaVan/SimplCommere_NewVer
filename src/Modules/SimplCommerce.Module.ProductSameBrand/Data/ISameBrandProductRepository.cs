using System.Linq;
using SimplCommerce.Module.Catalog.Models;
namespace SimplCommerce.Module.ProductSameBrand.Data
{
    public interface ISameBrandProductRepository
    {
        IQueryable<Product> GetSameBrandProduct(long brandId);
    }
}