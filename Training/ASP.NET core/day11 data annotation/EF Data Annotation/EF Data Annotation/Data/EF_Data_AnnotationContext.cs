using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EF_Data_Annotation.Models;

namespace EF_Data_Annotation.Data
{
    public class EF_Data_AnnotationContext : DbContext
    {
        public EF_Data_AnnotationContext (DbContextOptions<EF_Data_AnnotationContext> options)
            : base(options)
        {
        }

        public DbSet<EF_Data_Annotation.Models.Employee> Employee { get; set; }
    }
}
