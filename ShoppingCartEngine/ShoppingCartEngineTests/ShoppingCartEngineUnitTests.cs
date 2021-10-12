using FluentAssertions;
using ShoppingCartEngine.Controller;
using ShoppingCartEngine.Models;
using Xunit;

namespace ShoppingCartEngineTests
{
    public class ShoppingCartEngineUnitTests
    {
        [Theory]
        [InlineData(ProductTypes.BOOK, "Created packaging slip for shipping.")]
        [InlineData(ProductTypes.OTHER, "Created packaging slip for shipping.")]
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
        [InlineData(ProductTypes.BOOK, "Commission paid to the agent.")]
        [InlineData(ProductTypes.OTHER, "Commission paid to the agent.")]
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
        [InlineData(ProductTypes.BOOK,"kite runner", "Created a duplicate slip for royalty department for kite runner author.")]
        public void Should_Create_Duplicate_Slip_For_Royalty_Department_For_BookPurchased(ProductTypes type,string bookName, string expectedResult)
        {
            // Setup
            var sut = new PaymentController();

            // Exercise
            var result = sut.HandlePayment(type, bookName);

            // Verify
            result.ActionMessages.Should().ContainEquivalentOf(expectedResult);
        }

        [Theory]
        [InlineData(ProductTypes.VIDEO,"Learning to Ski", "You get a Free First Aid Video with your purchase of Learning to Ski video.")]
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
        [InlineData(ProductTypes.MEMBERSHIP, "Your membership is activated.")]
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
        [InlineData(ProductTypes.UPGRADE, "Upgrade to your membership is done.")]
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
        [InlineData(ProductTypes.UPGRADE,"xyz@pqr.com", "Mail Sent to xyz@pqr.com for upgrade.")]
        [InlineData(ProductTypes.MEMBERSHIP,"abc@xyz.com", "Mail Sent to abc@xyz.com for membership.")]
        public void Should_Inform_Users_About_Membership_Activation_Or_Upgrade(ProductTypes type,string emailId, string expectedResult)
        {
            // Setup
            var sut = new PaymentController();

            // Exercise
            var result = sut.HandlePayment(type,emailId);

            // Verify
            result.ActionMessages.Should().ContainEquivalentOf(expectedResult);
        }

        [Theory]
        [InlineData(ProductTypes.NONE, "Your cart is empty. Please enter a product.")]
        public void Should_Ask_Users_To_Enter_Product_If_Not_Entered(ProductTypes type, string expectedResult)
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
