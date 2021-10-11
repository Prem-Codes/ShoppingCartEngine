using System;
using System.Collections.Generic;
using System.Text;
using ShoppingCartEngine.Models;

namespace ShoppingCartEngine.Handlers
{
    public class VideoPaymentHandler : OtherProducts
    {
        public VideoPaymentHandler(string videoName)
        {
            base.GetPackagingSlip();
            ActionMessages = AddFreeVideo(videoName);
            ProductName = videoName;
        }

        public List<string> AddFreeVideo(string videoName)
        {
            ActionMessages = new List<string>();
            if (ProductName.ToLower().Contains("learning to ski"))
            {
                ActionMessages.Add($"Hurray. You get a Free Video with your purchase of {videoName}");
            }

            return ActionMessages;
        }
    }
}
