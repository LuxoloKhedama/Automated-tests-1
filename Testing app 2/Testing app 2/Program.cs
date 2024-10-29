using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_app_2
{
   public class Program
    {
        static void Main(string[] args)
        {
            var product = new Product("Sugar", 10.99, 5); // Set max quantity to 5
            var cart = new Cart();

            while (true)
            {
                Console.WriteLine("Press 'A' to add product to cart or 'Q' to quit:");
                var key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.A)
                {
                    cart.AddProductFromInput(product);
                }
                else if (key == ConsoleKey.Q)
                {
                    break;
                }

                cart.DisplayCart();
            }

            Console.WriteLine("Thank you for shopping!");
        }
    }
}