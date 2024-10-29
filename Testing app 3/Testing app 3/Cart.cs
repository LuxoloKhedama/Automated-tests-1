using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_app_3
{
    public class Cart
    {
        private HashSet<string> items;

        public Cart()
        {
            items = new HashSet<string>();
        }

        public void AddToCart(string item)
        {
            if (items.Add(item))
            {
                Console.WriteLine("{item} has been added to the cart.");
            }
            else
            {
                Console.WriteLine("{item} is already in the cart.");
            }
        }

        public void DisplayCart()
        {
            Console.WriteLine("Current items in the cart:");
            foreach (var item in items)
            {
                Console.WriteLine("- {item}");
            }
        }
        public int ItemCount()
        {
            return items.Count;
        }
    }
    }

