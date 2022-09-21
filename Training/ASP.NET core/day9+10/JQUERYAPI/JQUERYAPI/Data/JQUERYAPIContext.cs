using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JQUERYAPI.Models;

namespace JQUERYAPI.Data
{
    public class JQUERYAPIContext : DbContext
    {
        public JQUERYAPIContext (DbContextOptions<JQUERYAPIContext> options)
            : base(options)
        {
        }

        public DbSet<JQUERYAPI.Models.Student> Student { get; set; }
    }
}
