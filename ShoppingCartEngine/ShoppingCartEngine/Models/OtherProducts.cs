using System;
using System.Collections.Generic;
using System.Text;
using ShoppingCartEngine.Interfaces;

namespace ShoppingCartEngine.Models
{
    public class OtherProducts : Product, INotifyUser, IMembershipActivation, IApplyUpgrade, IAddFreeVideo
    {
        public override void GetPackagingSlip()
        {
            ActionMessages.Add("Created packaging slip for shipping");
        }

        public void DropMailToUser()
        {
            ActionMessages.Add("Mail Sent");
        }

        public void ActivateMembership()
        {
            ActionMessages.Add("Your membership is activated");
        }

        public void ApplyUpgrade()
        {
            ActionMessages.Add("Upgrade to your membership is done");
        }

        public void AddFreeVideo(string videoName)
        {
            if (videoName.ToLower().Contains("learning to ski"))
            {
                ActionMessages.Add($"Hurray. You get a Free Video with your purchase of {videoName}");
            }
        }
    }
}
