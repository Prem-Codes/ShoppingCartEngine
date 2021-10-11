using System;
using System.Collections.Generic;
using System.Text;
using ShoppingCartEngine.Models;

namespace ShoppingCartEngine.Controller
{
    public class PaymentController
    {
        public Product HandlePayment(ProductTypes type, string itemName="")
        {
            if (type == ProductTypes.BOOK || type == ProductTypes.OTHER)
            {
                return HandlePaymentforPhysicalProduct(type, itemName);
            }
            else
            {
                return HandlePaymentforNonPhysicalProduct(type, itemName);
            }
        }

        private Product HandlePaymentforPhysicalProduct(ProductTypes type, string itemName)
        {
            Product product = new Product {ActionMessages = new List<string> {"Generated Packing Slip."}};

            Console.WriteLine("Generated Packing Slip.");
            
            product.ActionMessages.Add("Commission Payment to the Agent.");
            Console.WriteLine("Commission Payment to the Agent.");

            if (type == ProductTypes.BOOK)
            {
                product.ProductName = string.IsNullOrEmpty(itemName) ? itemName : String.Empty;
                product.ActionMessages.Add("Created a duplicate slip for the royalty department.");
                Console.WriteLine("Created a duplicate slip for the royalty department.");
            }

            product.ProductType = type;
            return product;
        }

        private Product HandlePaymentforNonPhysicalProduct(ProductTypes type, string itemName)
        {
            Product product = new Product {ActionMessages = new List<string>()};

            if (type == ProductTypes.VIDEO)
            {
                if (itemName.ToLower().Contains("learning to ski."))
                {
                    product.ProductName = string.IsNullOrEmpty(itemName) ? itemName : String.Empty;
                    product.ActionMessages.Add("You get a free First Aid Video.");
                    Console.WriteLine("You get a free First Aid Video.");
                }
            }

            if (type == ProductTypes.MEMBERSHIP)
            {
                product.ActionMessages.Add("Membership Activated.");
                Console.WriteLine("Membership Activated.");
            }

            if (type == ProductTypes.UPGRADE)
            {
                product.ActionMessages.Add("Upgrade to the membership applied.");
                Console.WriteLine("Upgrade to the membership applied.");
            }

            if (type == ProductTypes.MEMBERSHIP || type == ProductTypes.UPGRADE)
            {
                product.ActionMessages.Add($"email regarding the {type.ToString().ToLower()} sent to user.");
                Console.WriteLine($"email regarding the {type.ToString().ToLower()} sent to user.");
            }

            product.ProductType = type;
            return product;
        }
    }
}
