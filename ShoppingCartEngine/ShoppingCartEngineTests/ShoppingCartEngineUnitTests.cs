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
        public void Should_Generate_Packing_Slip_For_PhysicalProducts(ProductTypes type, string expectedResult)
        {
            // Setup
            var sut = new PaymentController();

            // Exercise
            var result = sut.HandlePayment(type);

            // Verify
            result.ActionMessages.Should().ContainEquivalentOf(expectedResult);
        }

        [Theory]
        [InlineData(ProductTypes.BOOK, "Commission Payment to the Agent.")]
        [InlineData(ProductTypes.OTHER, "Commission Payment to the Agent.")]
        public void Should_Pay_Commission_To_Agent_For_PhysicalProducts(ProductTypes type, string expectedResult)
        {
            // Setup
            var sut = new PaymentController();

            // Exercise
            var result = sut.HandlePayment(type);

            // Verify
            result.ActionMessages.Should().ContainEquivalentOf(expectedResult);
        }

        [Theory]
        [InlineData(ProductTypes.BOOK, "Created a duplicate slip for the royalty department.")]
        public void Should_Create_Duplicate_Slip_For_Royalty_Department_For_BookPurchased(ProductTypes type, string expectedResult)
        {
            // Setup
            var sut = new PaymentController();

            // Exercise
            var result = sut.HandlePayment(type);

            // Verify
            result.ActionMessages.Should().ContainEquivalentOf(expectedResult);
        }

        [Theory]
        [InlineData(ProductTypes.VIDEO,"Learning to Ski.", "You get a free First Aid Video.")]
        public void Should_Add_First_Aid_Video_For_Learning_to_Ski_VideoPurchased(ProductTypes type,string itemName, string expectedResult)
        {
            // Setup
            var sut = new PaymentController();

            // Exercise
            var result = sut.HandlePayment(type, itemName);

            // Verify
            result.ActionMessages.Should().ContainEquivalentOf(expectedResult);
        }
    }
}
