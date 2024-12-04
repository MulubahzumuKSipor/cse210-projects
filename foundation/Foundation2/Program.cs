using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address(
            "Plot 23, Independence Avenue",
            "Accra",
            "Greater Accra",
            "Ghana"
        );
        Address address2 = new Address("15 Kumasi Road", "Kumasi", "Ashanti Region", "Ghana");

        Customer customer1 = new Customer("Kwame Mensah", address1);
        Customer customer2 = new Customer("Ama Asante", address2);

        Product product1 = new Product("Toyota Hilux", "TH123", 25000.0, 3);
        Product product2 = new Product("Nissan Patrol", "NP456", 30000.0, 2);
        Product product3 = new Product("Hyundai Accent", "HA789", 15000.0, 4);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        Console.WriteLine("Order 1 Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("\nOrder 1 Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"\nOrder 1 Total Cost: ${order1.TotalCost():F2}\n");

        Console.WriteLine("Order 2 Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("\nOrder 2 Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"\nOrder 2 Total Cost: ${order2.TotalCost():F2}");
    }
}
