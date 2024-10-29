using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_app_2
{
    public class Cart
    {
        private List<Product> _products = new List<Product>();

        public void AddProduct(Product product, int quantity)
        {
            var existingProduct = _products.Find(p => p.Name == product.Name);

            if (existingProduct != null)
            {
                // Check if adding the quantity exceeds the maximum limit
                if (existingProduct.Quantity + quantity > existingProduct.MaxQuantity)
                {
                    Console.WriteLine("Cannot add {quantity} of {product.Name}. Exceeds maximum quantity of {existingProduct.MaxQuantity}.");
                    return; // Exit the method if the limit is exceeded
                }

                existingProduct.Quantity += quantity; // Update existing quantity
            }
            else
            {
                // Check if adding the quantity exceeds the maximum limit
                if (quantity > product.MaxQuantity)
                {
                    Console.WriteLine("Cannot add {quantity} of {product.Name}. Exceeds maximum quantity of {product.MaxQuantity}.");
                    return; // Exit the method if the limit is exceeded
                }

                product.Quantity = quantity;  // Set the quantity for the new product
                _products.Add(product);
            }
        }
        public void DisplayCart()
    {
        Console.WriteLine("Cart Contents:");
        foreach (var product in _products)
        {
            Console.WriteLine("{product.Name}: {product.Quantity} x ${product.Price} = ${product.Quantity * product.Price}");
        }
    }
        public int GetProductQuantity(Product product)
        {
            var existingProduct = _products.Find(p => p.Name == product.Name);
            if (existingProduct != null)
            {
                return existingProduct.Quantity; // Return the quantity if found
            }
            return 0; // Return 0 if not found
        }
    public void AddProductFromInput(Product product)
    {
        Console.Write("Enter quantity to add for {product.Name}: ");
        int quantity; // Declare quantity here
        if (int.TryParse(Console.ReadLine(), out quantity) && quantity > 0)
        {
            AddProduct(product, quantity);
        }
        else
        {
            Console.WriteLine("Invalid quantity. Please enter a positive number.");
        }
    }
    }
}
