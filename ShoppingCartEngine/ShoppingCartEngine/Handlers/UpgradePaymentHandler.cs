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
            ActionMessages = new List<string> { "Upgrade to your membership is done" };
            base.GetPackagingSlip();
            base.DropMailToUser();
        }
    }
}
