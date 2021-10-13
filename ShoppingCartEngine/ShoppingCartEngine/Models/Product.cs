using System.Collections.Generic;

namespace ShoppingCartEngine.Models
{
    public abstract class Product
    {
        public ProductTypes ProductType { get; set; }
        public string ProductName { get; set; }

        public List<string> ActionMessages { get; set; }

        public abstract void GetPackagingSlip();
    }
}