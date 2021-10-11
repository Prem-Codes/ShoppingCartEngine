using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCartEngine.Models
{
    public class OtherProducts : Product
    {
        public override void GetPackagingSlip()
        {
            ActionMessages.Add("Created packaging slip for shipping");
        }

        public virtual void DropMailToUser()
        {
            ActionMessages.Add("Mail Sent");
        }
    }
}
