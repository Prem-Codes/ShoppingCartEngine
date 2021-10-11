using System;
using System.Collections.Generic;
using System.Text;
using ShoppingCartEngine.Models;

namespace ShoppingCartEngine.Controller
{
    public class PaymentController
    {
        public Product HandlePayment(ProductTypes type)
        {
            if (type == ProductTypes.BOOK || type == ProductTypes.OTHER)
            {
                return HandlePaymentforPhysicalProduct(type);
            }
            else
            {
                return new Product();
            }
        }

        private Product HandlePaymentforPhysicalProduct(ProductTypes type)
        {
            Product product = new Product();
            product.ActionMessages = new List<string>();

            product.ActionMessages.Add("Generated Packing Slip.");
            Console.WriteLine("Generated Packing Slip.");
            
            product.ActionMessages.Add("Commission Payment to the Agent.");
            Console.WriteLine("Commission Payment to the Agent.");

            if (type == ProductTypes.BOOK)
            {
                product.ActionMessages.Add("Created a duplicate slip for the royalty department.");
                Console.WriteLine("Created a duplicate slip for the royalty department.");
            }
            product.ProductName = type.ToString();
            return product;
        }
    }
}
