using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCProject2.Models;

namespace MVCProject2.Data
{
    public class MVCProject2Context : DbContext
    {
        public MVCProject2Context (DbContextOptions<MVCProject2Context> options)
            : base(options)
        {
        }

        public DbSet<MVCProject2.Models.Student> Student { get; set; }
    }
}
