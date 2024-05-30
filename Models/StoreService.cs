using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FVJASP1.Models
{
    public class StoreService
    {
        private readonly ApplicationDBContext _context;

        public StoreService(ApplicationDBContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _context.Products.ToList();
        }

        public async Task AddProductAsync(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
        }
    }
}
