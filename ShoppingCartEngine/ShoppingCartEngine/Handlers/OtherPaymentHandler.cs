using System;
using System.Collections.Generic;
using System.Text;
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
            base.SentCommissionToAgent();
        }
    }
}
