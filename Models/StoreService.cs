using System.Collections.Generic;
using System.Linq;

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
    }
}
