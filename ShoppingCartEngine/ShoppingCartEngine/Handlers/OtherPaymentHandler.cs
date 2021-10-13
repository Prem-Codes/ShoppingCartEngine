using System.Collections.Generic;
using ShoppingCartEngine.Models;

namespace ShoppingCartEngine.Handlers
{
    public class OtherPaymentHandler : PhysicalProduct
    {
        public OtherPaymentHandler()
        {
            ProductType = ProductTypes.OTHER;
            ActionMessages = new List<string>();
            base.GetPackagingSlip();
            SentCommissionToAgent();
        }
    }
}