using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Day4MVCProject.Models;

namespace Day4MVCProject.Data
{
    public class Day4MVCProjectContext : DbContext
    {
        public Day4MVCProjectContext (DbContextOptions<Day4MVCProjectContext> options)
            : base(options)
        {
        }

        public DbSet<Day4MVCProject.Models.Customer> Customer { get; set; }
    }
}
