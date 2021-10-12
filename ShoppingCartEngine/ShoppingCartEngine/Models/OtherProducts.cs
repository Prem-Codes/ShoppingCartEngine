using ShoppingCartEngine.Interfaces;

namespace ShoppingCartEngine.Models
{
    public class OtherProducts : Product, INotifyUser, IMembershipActivation, IApplyUpgrade, IAddFreeVideo
    {
        public override void GetPackagingSlip()
        {
            ActionMessages.Add("Created packaging slip for shipping.");
        }

        public void DropMailToUser(string emailId, ProductTypes type)
        {
            ActionMessages.Add($"Mail Sent to {emailId} for {type.ToString().ToLower()}.");
        }

        public void ActivateMembership()
        {
            ActionMessages.Add("Your membership is activated.");
        }

        public void ApplyUpgrade()
        {
            ActionMessages.Add("Upgrade to your membership is done.");
        }

        public void AddFreeVideo(string videoName)
        {
            if (videoName.ToLower().Contains("learning to ski"))
            {
                ActionMessages.Add($"You get a Free First Aid Video with your purchase of {videoName} video.");
            }
        }
    }
}
