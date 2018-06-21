using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCWebAPITutorial.Models {


    public class MVCWebAPIDBContext : DbContext {

        public MVCWebAPIDBContext() : base() { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
    }


}