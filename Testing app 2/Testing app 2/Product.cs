using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_app_2
{
   public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public int MaxQuantity { get; set; } // Maximum quantity allowed
        public Product(string name, double price, int maxQuantity)
        {
            Name = name;
            Price = price;
            Quantity = 5;
            MaxQuantity = maxQuantity;  // Set max quantity
        }
    }
}
