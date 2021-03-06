using SalesWebMVC3._1.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace SalesWebMVC3._1.Models.Services
{
    public class SalesRecordService
    {
        private readonly SalesWebMVC3_1Context _context;

        public SalesRecordService(SalesWebMVC3_1Context context)
        {
            _context = context;
        }

        public async Task<List<SalesRecord>> FindBydDateAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.SalesRecord select obj;
            if (minDate.HasValue)
            {
                result = result.Where(x => x.Date >= minDate.Value);
            }
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.Date <= maxDate.Value);
            }
            return await result
                .Include(x => x.Seller)
                .Include(x => x.Seller.Departament)
                .OrderByDescending(x => x.Date)
                .ToListAsync();
        }
    }
}
