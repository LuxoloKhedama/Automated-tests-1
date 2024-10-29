using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_app_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Cart cart = new Cart();
            bool running = true;

            while (running)
            {
                Console.WriteLine("Enter a product name to add to the cart (or 'exit' to quit):");
                string product = Console.ReadLine();

                if (product.ToLower() == "exit")
                {
                    running = false;
                }
                else
                {
                    cart.AddToCart(product);
                }

                cart.DisplayCart();
            }
        }
        }
    }

