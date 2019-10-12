using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APP.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public virtual Category category { get; set; }
    }
}