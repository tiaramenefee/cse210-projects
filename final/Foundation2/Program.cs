using System;

class Program
{
    static void Main()
    {
        Address address1 = new Address("123 Elm St", "New York", "NY", "USA");
        Customer customer1 = new Customer("John Doe", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", 101, 1200.00, 1));
        order1.AddProduct(new Product("Mouse", 102, 25.00, 2));

        Address address2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Monitor", 201, 300.00, 1));
        order2.AddProduct(new Product("Keyboard", 202, 50.00, 1));

        Console.WriteLine("Order 1 Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("\nOrder 1 Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"\nOrder 1 Total Price: ${order1.GetTotalPrice():F2}\n");

        Console.WriteLine("Order 2 Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("\nOrder 2 Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"\nOrder 2 Total Price: ${order2.GetTotalPrice():F2}");
    }
}
