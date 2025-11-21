using System;

class Program
{
    static void Main(string[] args)
    {
        // ---------- ORDER #1 ----------
        Address address1 = new Address("123 Apple St", "Dallas", "TX", "USA");
        Customer customer1 = new Customer("John Smith", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Keyboard", "K123", 25.99, 1));
        order1.AddProduct(new Product("Mouse", "M456", 15.99, 2));
        order1.AddProduct(new Product("USB Cable", "U789", 4.50, 3));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost()}\n");


        // ---------- ORDER #2 ----------
        Address address2 = new Address("75 Sakura Rd", "Tokyo", "Tokyo", "Japan");
        Customer customer2 = new Customer("Aiko Tanaka", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Laptop", "L999", 899.99, 1));
        order2.AddProduct(new Product("Headphones", "H111", 59.99, 1));

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost()}");
    }
}
