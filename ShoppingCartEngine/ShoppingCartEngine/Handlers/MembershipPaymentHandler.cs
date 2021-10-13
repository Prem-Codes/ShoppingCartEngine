using System.Collections.Generic;
using ShoppingCartEngine.Models;

namespace ShoppingCartEngine.Handlers
{
    public class MembershipPaymentHandler : OtherProducts
    {
        public MembershipPaymentHandler(string emailId)
        {
            ProductType = ProductTypes.MEMBERSHIP;
            ActionMessages = new List<string>();
            base.GetPackagingSlip();
            ActivateMembership();
            DropMailToUser(emailId, ProductType);
        }
    }
}