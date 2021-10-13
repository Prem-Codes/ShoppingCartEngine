using ShoppingCartEngine.Interfaces;

namespace ShoppingCartEngine.Models
{
    public class PhysicalProduct : Product, ICommissionToAgent, IDuplicateSlip
    {
        public void SentCommissionToAgent()
        {
            ActionMessages.Add("Commission paid to the agent.");
        }

        public void CreateDuplicateSlip(string itemName)
        {
            ActionMessages.Add($"Created a duplicate slip for royalty department for {itemName} author.");
        }

        public override void GetPackagingSlip()
        {
            ActionMessages.Add("Created packaging slip for shipping.");
        }
    }
}