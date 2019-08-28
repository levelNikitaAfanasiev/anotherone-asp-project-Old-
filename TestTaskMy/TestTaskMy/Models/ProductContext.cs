using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TestTaskMy.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("Product_types")
        { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category_type> Category_types { get; set; }


    }

}