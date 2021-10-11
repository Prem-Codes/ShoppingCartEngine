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
            ProductType = ProductTypes.MEMBERSHIP;
            base.ActionMessages = new List<string>();
            base.GetPackagingSlip();
            base.ActivateMembership();
            base.DropMailToUser();
        }
    }
}
