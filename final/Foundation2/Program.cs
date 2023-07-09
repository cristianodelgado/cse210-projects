using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("Plane toy", 123, 2, 59.49);
        Product product2 = new Product("Lion", 234, 1, 12.99);

        Address address1 = new Address("687 Eagle St", "Orem", "Utah", "USA");
        Address address2 = new Address("291 Canova", "Villa Maria", "Cordoba", "Argentina");

        Customer customer1 = new Customer("Natalia Tacconi", address1);
        Customer customer2 = new Customer("Nadia Rodriguez", address2);

        Order order1 = new Order(customer1);
        order1.AddProducts(product1);
        order1.AddProducts(product2);

        Order order2 = new Order(customer2);
        order2.AddProducts(product1);

        Console.WriteLine("Order 1");
        Console.WriteLine("Packing Label: ");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Shipping Label: ");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order1.GetTotalPrice());

        Console.WriteLine("Order 2");
        Console.WriteLine("Packing Label: ");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Shipping Label: ");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order2.GetTotalPrice());


    }
}