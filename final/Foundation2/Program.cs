using System;
using System.Collections.Generic;

namespace ProductOrderingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create some products
            Product product1 = new Product("Special Gift Card", "SSD 200-901", 49.99m, 1);
            Product product2 = new Product("Animated Gun of Clove - Valorant", "LMRT 200-301", 39.99m, 5);
            Product product3 = new Product("Animated Gun of Phoenix - Valorant", "EXFT 350-401", 47.99m, 2);

            // Create a customer
            Address address = new Address("698 Lord Chrochane", "Providencia", "Santiago", "Chile");
            Customer customer = new Customer("Pedro Perez", address);

            // Create an order
            List<Product> products = new List<Product>();
            products.Add(product1);
            products.Add(product2);
            products.Add(product3);
            Order order = new Order(customer, products);

            // Output the packing label and shipping label
            Console.WriteLine("Packing Label:");
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine("Shipping Label:");
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine("Total Cost: $" + order.GetTotalCost().ToString("0.00"));
        }
    }
}