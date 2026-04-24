using PamirPlastik.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PamirPlastik.Application.Interfaces
{
    public interface IProductRepository : IRepository<Product>
    {
       
        Task<List<Product>> GetProductsWithCategoryAsync();

        Task<List<Product>> GetFeaturedProductsWithCategoryAsync();
    }
}
