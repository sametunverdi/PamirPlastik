using Microsoft.EntityFrameworkCore;
using PamirPlastik.Application.Interfaces;
using PamirPlastik.Domain.Entities;
using PamirPlastik.Persistence.Context;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PamirPlastik.Persistence.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly PamirPlastikContext _context;

        public ProductRepository(PamirPlastikContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<Product>> GetProductsWithCategoryAsync()
        {
            // .Include(x => x.Category) sayesinde CategoryName null gelmez kanka
            return await _context.Products
                .Include(x => x.Category)
                .ToListAsync();
        }

        public async Task<List<Product>> GetFeaturedProductsWithCategoryAsync()
        {
            return await _context.Products
                .Where(x => x.IsFeatured == true)
                .Include(x => x.Category)
                .ToListAsync();
        }
    }
}