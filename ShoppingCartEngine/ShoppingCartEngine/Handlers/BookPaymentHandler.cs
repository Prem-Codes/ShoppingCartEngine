using System;
using System.Collections.Generic;
using System.Text;
using ShoppingCartEngine.Models;

namespace ShoppingCartEngine.Handlers
{
    public class BookPaymentHandler : PhysicalProduct
    {
        public BookPaymentHandler(string itemName)
        {
            ProductName = itemName;
            ProductType = ProductTypes.BOOK;
            ActionMessages = new List<string>();
            base.GetPackagingSlip();
            base.SentCommissionToAgent();
            base.CreateDuplicateSlip(itemName);
        }
    }
}
