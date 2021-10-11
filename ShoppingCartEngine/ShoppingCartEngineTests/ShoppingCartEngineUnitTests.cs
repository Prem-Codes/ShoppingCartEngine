using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using ShoppingCartEngine.Controller;
using ShoppingCartEngine.Models;
using Xunit;

namespace ShoppingCartEngineTests
{
    public class ShoppingCartEngineUnitTests
    {
        [Theory]
        [InlineData(ProductTypes.BOOK, "Generated Packing Slip.")]
        [InlineData(ProductTypes.OTHER, "Generated Packing Slip.")]
        public void ShouldGeneratePackingSlipForPhysicalProducts(ProductTypes type, string expectedResult)
        {
            // Setup
            var sut = new PaymentController();

            // Exercise
            var result = sut.HandlePayment(type);

            // Verify
            result.ActionMessages.Should().Contain(expectedResult);
        }
    }
}
