using System;
using Testing_app_2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddProduct_ShouldNotExceedMaxQuantity()
        {
        // Arrange
        var product = new Product("Sugar", 10.99, 5); // Max quantity is 5
        var cart = new Cart();

        // Act
        cart.AddProduct(product, 3); // Add 3
        cart.AddProduct(product, 4); // Try to add 4 (exceeds max)

        // Assert
        Assert.AreEqual(3, cart.GetProductQuantity(product)); // Should be 3
        }
       }
    
}

