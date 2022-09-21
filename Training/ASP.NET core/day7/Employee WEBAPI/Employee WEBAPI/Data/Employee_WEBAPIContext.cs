using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Employee_WEBAPI.Model;

namespace Employee_WEBAPI.Data
{
    public class Employee_WEBAPIContext : DbContext
    {
        public Employee_WEBAPIContext (DbContextOptions<Employee_WEBAPIContext> options)
            : base(options)
        {
        }

        public DbSet<Employee_WEBAPI.Model.Employee> Employee { get; set; }
    }
}
