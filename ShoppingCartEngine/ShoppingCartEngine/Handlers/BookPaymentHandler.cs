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
            ActionMessages = new List<string> {$"Created a duplicate slip for royalty department for {itemName}"};
            base.GetPackagingSlip();
            base.SentCommissionToAgent();
        }
    }
}
