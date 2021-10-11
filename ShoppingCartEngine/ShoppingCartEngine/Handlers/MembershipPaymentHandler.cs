using System.Collections.Generic;
using ShoppingCartEngine.Models;

namespace ShoppingCartEngine.Handlers
{
    public class MembershipPaymentHandler : OtherProducts
    {
        public MembershipPaymentHandler()
        {
            ProductType = ProductTypes.MEMBERSHIP;
            ActionMessages = new List<string>();
            base.GetPackagingSlip();
            ActivateMembership();
            DropMailToUser();
        }
    }
}
