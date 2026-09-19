using PamirPlastik.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Interfaces
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<List<Product>> GetProductsWithCategoryAsync();
        Task<List<Product>> GetFeaturedProductsWithCategoryAsync();
        Task<Product> GetProductBySlugAsync(string slug);
    }
}
