using Microsoft.EntityFrameworkCore;
using SalesWebMVC3._1.Models;

namespace SalesWebMVC3._1.Data
{
    public class SalesWebMVC3_1Context : DbContext
    {
        public SalesWebMVC3_1Context(DbContextOptions<SalesWebMVC3_1Context> options)
            : base(options)
        {
        }

        public DbSet<Departament> Departament { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}
