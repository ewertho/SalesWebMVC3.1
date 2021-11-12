using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMVC3._1.Models;

namespace SalesWebMVC3._1.Data
{
    public class SalesWebMVC3_1Context : DbContext
    {
        public SalesWebMVC3_1Context (DbContextOptions<SalesWebMVC3_1Context> options)
            : base(options)
        {
        }

        public DbSet<SalesWebMVC3._1.Models.Departament> Departament { get; set; }
    }
}
