using ShoppingCartEngine.Models;

namespace ShoppingCartEngine.Interfaces
{
    public interface INotifyUser
    {
        void DropMailToUser(string emailId, ProductTypes type);
    }
}