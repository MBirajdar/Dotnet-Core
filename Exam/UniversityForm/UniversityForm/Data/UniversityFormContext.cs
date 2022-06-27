using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UniversityForm.Models;

namespace UniversityForm.Data
{
    public class UniversityFormContext : DbContext
    {
        public UniversityFormContext (DbContextOptions<UniversityFormContext> options)
            : base(options)
        {
        }

        public DbSet<UniversityForm.Models.Student> Student { get; set; }
    }
}
