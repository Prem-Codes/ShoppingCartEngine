using System;
using System.Collections.Generic;
using System.Text;
using ShoppingCartEngine.Models;

namespace ShoppingCartEngine.Handlers
{
    public class MembershipPaymentHandler : OtherProducts
    {
        public MembershipPaymentHandler()
        {
            ActionMessages = new List<string> { "Your membership is activated" };
            base.GetPackagingSlip();
            base.DropMailToUser();
        }
    }
}
