using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCWebAPITutorial.Models;

namespace MVCWebAPITutorial.Models {

    public class Order {

        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Total { get; set; }
        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }

        public Order() { }
    }
}