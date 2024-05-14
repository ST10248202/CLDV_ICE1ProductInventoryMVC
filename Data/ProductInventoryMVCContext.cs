using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProductInventoryMVC.Models;

namespace ProductInventoryMVC.Data
{
    public class ProductInventoryMVCContext : DbContext
    {
        public ProductInventoryMVCContext (DbContextOptions<ProductInventoryMVCContext> options)
            : base(options)
        {
        }

        public DbSet<ProductInventoryMVC.Models.Product> Product { get; set; } = default!;
        //change below
        public DbSet<Product> Products { get; set; }

    }
}
