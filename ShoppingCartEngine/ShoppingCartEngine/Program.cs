using System;
using ShoppingCartEngine.Controller;
using ShoppingCartEngine.Models;

namespace ShoppingCartEngine
{
    public class Program
    {
        static void Main(string[] args)
        {
            var paymentController = new PaymentController();
            ProductTypes type = ProductTypes.NONE;
            string userInput = "";

            foreach (ProductTypes value in Enum.GetValues(typeof(ProductTypes)))
            {
                if (value != type)
                {
                    Console.WriteLine("{0,3}   {1}",
                        (int)value, value);
                }
            }

            Console.WriteLine("Enter the Name of the product you want to purchase from the above list");

            var userSelection = Console.ReadLine();
            if (userSelection != null) type = Enum.Parse<ProductTypes>(userSelection.ToUpper());

            if (type == ProductTypes.VIDEO)
            {
                Console.WriteLine("Enter Video Name: ");
                userInput = Console.ReadLine();
            }
            else if (type == ProductTypes.MEMBERSHIP || type == ProductTypes.UPGRADE)
            {
                Console.WriteLine("Enter your email id: ");
                userInput = Console.ReadLine();
            }
            else if (type == ProductTypes.BOOK)
            {
                Console.WriteLine("Enter the book name: ");
                userInput = Console.ReadLine();
            }


            var output = paymentController.HandlePayment(type, userInput);

            Console.WriteLine("Product Ordered : {0}\nActions Taken : {1}\n", output.ProductType, string.Join(Environment.NewLine, output.ActionMessages));
            Console.ReadLine();
        }
    }
}
