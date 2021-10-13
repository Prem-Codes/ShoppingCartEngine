using System.Collections.Generic;
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
            SentCommissionToAgent();
            CreateDuplicateSlip(itemName);
        }
    }
}