using System;

class Program
{
    static void Main(string[] args)
    {
        Order1();
        Order2();
        Order3();
    }

    static void Order1()
    {
        Address address = new Address("456 Elm Avenue", "Springfield", "NY", "USA");
        Customer customer = new Customer("Ethan Anderson", address);

        Product product1 = new Product("T-Shirt", 123456, 19.99, 3);
        Product product2 = new Product("Wireless Headphones", 789012, 49.99, 1);
        Product product3 = new Product("Leather Wallet", 345642, 29.99, 1);

        Order order = new Order();
        order.AddProduct(product1);
        order.AddProduct(product2);
        order.AddProduct(product3);
        
        order.SetCustomer(customer);
        order.SetPackingLabel();
        order.SetShippingLabel();
        order.SetShippingCost();

        string packingLabel = order.GetPackingLabel();
        string shippingLabel = order.GetShippingLabel();
        double totalPrice = order.GetTotalPrice();

        Console.WriteLine("Packing Label:");
        Console.WriteLine(packingLabel);
        
        Console.WriteLine("\nShipping Label:");
        Console.WriteLine(shippingLabel);
        Console.WriteLine($"${totalPrice}");

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
    }

    static void Order2()
    {
        Address address = new Address("789 Oaklane", "Lakeside", "TX", "USA");
        Customer customer = new Customer("Daniel Foster", address);

        Product product1 = new Product("Stainless Steel Water Bottle", 901234, 15.99, 2);
        Product product2 = new Product("Keyboard", 129931, 10.50, 1);
        Product product3 = new Product("Disposable Gloves", 342212, 6.99, 5);

        Order order = new Order();
        order.AddProduct(product1);
        order.AddProduct(product2);
        order.AddProduct(product3);
        
        order.SetCustomer(customer);
        order.SetPackingLabel();
        order.SetShippingLabel();
        order.SetShippingCost();

        string packingLabel = order.GetPackingLabel();
        string shippingLabel = order.GetShippingLabel();
        double totalPrice = order.GetTotalPrice();

        Console.WriteLine("Packing Label:");
        Console.WriteLine(packingLabel);
        
        Console.WriteLine("\nShipping Label:");
        Console.WriteLine(shippingLabel);
        Console.WriteLine($"${totalPrice}");

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
    }

    static void Order3()
    {
        Address address = new Address("Hauptstraße 10", "Berlin", "Berlin", "Germany");
        Customer customer = new Customer("Elias Luftensteiner", address);

        Product product1 = new Product("Swivel Chair", 129132, 39.99, 2);
        Product product2 = new Product("Rubber Ball", 119512, 2.50, 1);

        Order order = new Order();
        order.AddProduct(product1);
        order.AddProduct(product2);
        
        order.SetCustomer(customer);
        order.SetPackingLabel();
        order.SetShippingLabel();
        order.SetShippingCost();

        string packingLabel = order.GetPackingLabel();
        string shippingLabel = order.GetShippingLabel();
        double totalPrice = order.GetTotalPrice();

        Console.WriteLine("Packing Label:");
        Console.WriteLine(packingLabel);
        
        Console.WriteLine("\nShipping Label:");
        Console.WriteLine(shippingLabel);
        Console.WriteLine($"${totalPrice}");

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
    }
}