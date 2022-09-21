using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCAssignment.Models;

namespace MVCAssignment.Data
{
    public class MVCAssignmentContext : DbContext
    {
        public MVCAssignmentContext (DbContextOptions<MVCAssignmentContext> options)
            : base(options)
        {
        }

        public DbSet<MVCAssignment.Models.Product> Product { get; set; }
    }
}
