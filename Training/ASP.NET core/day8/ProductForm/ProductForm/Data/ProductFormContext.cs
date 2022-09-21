using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProductForm.Models;

namespace ProductForm.Data
{
    public class ProductFormContext : DbContext
    {
        public ProductFormContext (DbContextOptions<ProductFormContext> options)
            : base(options)
        {
        }

        public DbSet<ProductForm.Models.Product> Product { get; set; }
    }
}
