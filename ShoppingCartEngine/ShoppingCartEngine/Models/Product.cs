using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCartEngine.Models
{
    public class Product
    {
        public ProductTypes ProductType { get; set; }
        public string ProductName { get; set; }

        public List<string> ActionMessages { get; set; }
    }
}
