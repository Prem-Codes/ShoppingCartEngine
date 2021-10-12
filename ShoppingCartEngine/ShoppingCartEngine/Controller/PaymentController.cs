using System;
using ShoppingCartEngine.Handlers;
using ShoppingCartEngine.Models;

namespace ShoppingCartEngine.Controller
{
    public class PaymentController
    {
        public Product HandlePayment(ProductTypes type, string userInput="")
        {
            Product product;

            switch (type)
            {
                case ProductTypes.BOOK:
                {
                    product = new BookPaymentHandler(userInput);
                    break;
                }
                case ProductTypes.MEMBERSHIP:
                {
                    product = new MembershipPaymentHandler(userInput);
                    break;
                }
                case ProductTypes.UPGRADE:
                {
                    product = new UpgradePaymentHandler(userInput);
                    break;
                }
                case ProductTypes.VIDEO:
                {
                    product = new VideoPaymentHandler(userInput);
                    break;
                }
                case ProductTypes.OTHER:
                {
                    product = new OtherPaymentHandler();
                    break;
                }
                default:
                {
                    product = null;
                    Console.WriteLine("Your Cart is empty");
                    break;
                }
            }

            return product;
        }
    }
}
