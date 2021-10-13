using System.Collections.Generic;
using ShoppingCartEngine.Models;

namespace ShoppingCartEngine.Handlers
{
    public class NoPaymentHandler : OtherProducts
    {
        public NoPaymentHandler()
        {
            ProductType = ProductTypes.NONE;
            ActionMessages = new List<string> {"Your cart is empty. Please enter a product."};
        }
    }
}