using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Final_code_base_test.Models;

namespace Final_code_base_test.Data
{
    public class Final_code_base_testContext : DbContext
    {
        public Final_code_base_testContext (DbContextOptions<Final_code_base_testContext> options)
            : base(options)
        {
        }

        public DbSet<Final_code_base_test.Models.Employee>? Employee { get; set; }
    }
}
