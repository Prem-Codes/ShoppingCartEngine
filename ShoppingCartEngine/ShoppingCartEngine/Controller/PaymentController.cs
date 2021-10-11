using System;
using System.Collections.Generic;
using System.Text;
using ShoppingCartEngine.Handlers;
using ShoppingCartEngine.Models;

namespace ShoppingCartEngine.Controller
{
    public class PaymentController
    {
        public Product HandlePayment(ProductTypes type, string itemName="")
        {
            Product product;

            switch (type)
            {
                case ProductTypes.BOOK:
                {
                    product = new BookPaymentHandler(itemName);
                    break;
                }
                case ProductTypes.MEMBERSHIP:
                {
                    product = new MembershipPaymentHandler();
                    break;
                }
                case ProductTypes.UPGRADE:
                {
                    product = new UpgradePaymentHandler();
                    break;
                }
                case ProductTypes.VIDEO:
                {
                    product = new VideoPaymentHandler(itemName);
                    break;
                }
                case ProductTypes.OTHER:
                default:
                {
                    product = new OtherPaymentHandler();
                    break;
                }
            }

            return product;
        }
    }
}
