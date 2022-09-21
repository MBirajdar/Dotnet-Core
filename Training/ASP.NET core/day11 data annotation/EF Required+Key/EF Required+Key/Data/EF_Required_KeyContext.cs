using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EF_Required_Key.Models;

namespace EF_Required_Key.Data
{
    public class EF_Required_KeyContext : DbContext
    {
        public EF_Required_KeyContext (DbContextOptions<EF_Required_KeyContext> options)
            : base(options)
        {
        }

        public DbSet<EF_Required_Key.Models.Employee> Employee { get; set; }
    }
}
