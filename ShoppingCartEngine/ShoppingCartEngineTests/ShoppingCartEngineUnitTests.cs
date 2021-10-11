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

        [Theory]
        [InlineData(ProductTypes.MEMBERSHIP, "Membership Activated.")]
        public void Should_Activate_Membership_For_Payment_For_MembershipActivation(ProductTypes type, string expectedResult)
        {
            // Setup
            var sut = new PaymentController();

            // Exercise
            var result = sut.HandlePayment(type);

            // Verify
            result.ActionMessages.Should().ContainEquivalentOf(expectedResult);
        }

        [Theory]
        [InlineData(ProductTypes.UPGRADE, "Upgrade to the membership applied.")]
        public void Should_Upgrade_Membership_For_Payment_For_MembershipUpgrade(ProductTypes type, string expectedResult)
        {
            // Setup
            var sut = new PaymentController();

            // Exercise
            var result = sut.HandlePayment(type);

            // Verify
            result.ActionMessages.Should().ContainEquivalentOf(expectedResult);
        }

        [Theory]
        [InlineData(ProductTypes.UPGRADE, "email regarding the upgrade sent to user.")]
        [InlineData(ProductTypes.MEMBERSHIP, "email regarding the membership sent to user.")]
        public void Should_Inform_Users_About_Membership_Activation_Or_Upgrade(ProductTypes type, string expectedResult)
        {
            // Setup
            var sut = new PaymentController();

            // Exercise
            var result = sut.HandlePayment(type);

            // Verify
            result.ActionMessages.Should().ContainEquivalentOf(expectedResult);
        }
    }
}
