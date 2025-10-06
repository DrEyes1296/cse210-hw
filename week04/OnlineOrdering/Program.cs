class Program
{
    static void Main(string[] args)
    {
        // --- Create Products ---
        Product p1 = new Product("Gaming Mouse", "G502", 49.99, 1);
        Product p2 = new Product("Mechanical Keyboard", "K840", 75.50, 1);
        Product p3 = new Product("4K Monitor", "M27", 349.99, 2);
        Product p4 = new Product("Webcam", "C920", 59.95, 1);
        Product p5 = new Product("USB-C Hub", "H11", 25.00, 1);

        // --- Order 1 (USA) ---
        Console.WriteLine("--- Order 1 ---");
        Address address1 = new Address("123 Elm Street", "Springfield", "IL", "USA");
        Customer customer1 = new Customer("John Smith", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(p1);
        order1.AddProduct(p2);
        order1.AddProduct(p5);
        
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost():0.00}\n");

        // --- Order 2 (International) ---
        Console.WriteLine("--- Order 2 ---");
        Address address2 = new Address("456 O'Connell St", "Dublin", "Dublin", "Ireland");
        Customer customer2 = new Customer("Mary O'Connor", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(p3);
        order2.AddProduct(p4);

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost():0.00}\n");
    }
}