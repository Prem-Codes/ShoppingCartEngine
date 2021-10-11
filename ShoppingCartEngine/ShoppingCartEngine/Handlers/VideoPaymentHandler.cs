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
            ProductName = videoName;
            ProductType = ProductTypes.VIDEO;
            ActionMessages = new List<string>();
            base.GetPackagingSlip();
            base.AddFreeVideo(videoName);
        }
    }
}
