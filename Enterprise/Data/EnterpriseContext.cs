using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Enterprise.Models;

namespace Enterprise.Data
{
    public class EnterpriseContext : DbContext
    {
        public EnterpriseContext (DbContextOptions<EnterpriseContext> options)
            : base(options)
        {
        }

        public DbSet<Enterprise.Models.Department> Department { get; set; } = default!;
        public DbSet<Enterprise.Models.Employee> Employee { get; set; } = default!;
    }
}
