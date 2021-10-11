using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCartEngine.Models
{
    public class PhysicalProduct : Product
    {
        public override void GetPackagingSlip()
        {
            ActionMessages.Add("Created packaging slip for shipping");
        }

        public virtual void SentCommissionToAgent()
        {
            ActionMessages.Add("Commission paid to the agent");
        }
    }
}
