using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TaskMvcProductOrder.Models
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext()
               : base("name=DefultConnection")
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<ProductOrder> ProductOrders { get; set; }
        public DbSet<User> Users { get; set; }
    }
}