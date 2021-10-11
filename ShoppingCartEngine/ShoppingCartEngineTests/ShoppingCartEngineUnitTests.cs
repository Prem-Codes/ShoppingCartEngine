using System;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Xunit;

namespace ShoppingCartEngineTests
{
    public class ShoppingCartEngineUnitTests
    {
        [Fact]
        public void ShouldGeneratePackingSlipForPhysicalProducts()
        {
            var result = Program.Main(new string[] { "physicalproduct", "Generated packing slip" })
        }
    }
}
