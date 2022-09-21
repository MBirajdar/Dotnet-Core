using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HomeForm.Models;

namespace HomeForm.Data
{
    public class HomeFormContext : DbContext
    {
        public HomeFormContext (DbContextOptions<HomeFormContext> options)
            : base(options)
        {
        }

        public DbSet<HomeForm.Models.Student> Student { get; set; }
    }
}
