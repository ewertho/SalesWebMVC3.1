using SalesWebMVC3._1.Data;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMVC3._1.Models.Services
{
    public class SellerService
    {
        private readonly SalesWebMVC3_1Context _context;
        
        public SellerService(SalesWebMVC3_1Context context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
    }
}
