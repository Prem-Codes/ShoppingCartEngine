using System;
using System.Collections.Generic;
using System.Text;
using ShoppingCartEngine.Models;

namespace ShoppingCartEngine.Handlers
{
    public class UpgradePaymentHandler : OtherProducts
    {
        public UpgradePaymentHandler()
        {
            ProductType = ProductTypes.UPGRADE;
            ActionMessages = new List<string>();
            base.GetPackagingSlip();
            base.ApplyUpgrade();
            base.DropMailToUser();
        }
    }
}
