using Microsoft.EntityFrameworkCore;
using SalesWebMVC3._1.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMVC3._1.Models.Services
{
    public class DepartamentService
    {
        private readonly SalesWebMVC3_1Context _context;

        public DepartamentService(SalesWebMVC3_1Context context)
        {
            _context = context;
        }

        public async Task<List<Departament>> FindAllAsync()
        {
            return await _context.Departament.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
