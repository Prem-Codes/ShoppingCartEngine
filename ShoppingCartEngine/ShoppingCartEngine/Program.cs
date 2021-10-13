using System;
using System.Linq;
using ShoppingCartEngine.Controller;
using ShoppingCartEngine.Models;

namespace ShoppingCartEngine
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var paymentController = new PaymentController();
            var type = ProductTypes.NONE;
            var userInput = "";
            var options = Enum.GetValues(typeof(ProductTypes)).Cast<ProductTypes>().Where(a => a != ProductTypes.NONE)
                .ToArray();

            Console.WriteLine(string.Join("\n", options));

            Console.WriteLine("Enter the Name of the product you want to purchase from the above list");

            var userSelection = Console.ReadLine();
            if (userSelection != null) type = Enum.Parse<ProductTypes>(userSelection.ToUpper());

            Console.WriteLine("Enter other details (fx. Video Name/ Book Name/ Email Id");
            userInput = Console.ReadLine();

            var output = paymentController.HandlePayment(type, userInput);

            Console.WriteLine("Product Ordered : {0}\nActions Taken : {1}\n", output.ProductType,
                string.Join(Environment.NewLine, output.ActionMessages));
            Console.ReadLine();
        }
    }
}