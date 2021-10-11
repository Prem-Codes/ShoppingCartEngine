﻿using System.Collections.Generic;
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
            ApplyUpgrade();
            DropMailToUser();
        }
    }
}
