using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the online ordering project.");

        // Creating first customer and order
        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Customer customer1 = new Customer("John Doe", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "A123", 899.99m, 1));
        order1.AddProduct(new Product("Mouse", "B456", 25.50m, 2));

        Console.WriteLine("\nOrder 1:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("\nShipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"\nTotal Price: ${order1.GetTotalPrice():F2}\n");

        // Creating second customer and order
        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Keyboard", "C789", 49.99m, 1));
        order2.AddProduct(new Product("Monitor", "D012", 199.99m, 1));

        Console.WriteLine("\nOrder 2:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("\nShipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"\nTotal Price: ${order2.GetTotalPrice():F2}");
    }
}










