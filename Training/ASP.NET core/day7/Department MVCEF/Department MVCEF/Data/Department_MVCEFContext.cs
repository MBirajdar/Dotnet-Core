using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Department_MVCEF.Models;

namespace Department_MVCEF.Data
{
    public class Department_MVCEFContext : DbContext
    {
        public Department_MVCEFContext (DbContextOptions<Department_MVCEFContext> options)
            : base(options)
        {
        }

        public DbSet<Department_MVCEF.Models.Department> Department { get; set; }
    }
}
