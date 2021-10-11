using System;
using ShoppingCartEngine.Controller;
using ShoppingCartEngine.Models;

namespace ShoppingCartEngine
{
    public class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                var paymentController = new PaymentController();
                string itemName = "";

                foreach (var value in Enum.GetValues(typeof(ProductTypes)))
                {
                    Console.WriteLine("{0,3}   {1}",
                        (int)value, ((ProductTypes)value));
                }

                Console.WriteLine("Enter the Name of the product you want to purchase from the above list");
                var userInput = Console.ReadLine();
                ProductTypes type = Enum.Parse<ProductTypes>(userInput.ToUpper());
                if (type == ProductTypes.VIDEO)
                {
                    Console.WriteLine("Enter Video Name: ");
                    itemName = Console.ReadLine();
                }

                var output = paymentController.HandlePayment(type, itemName);


            }
        }
    }
}
