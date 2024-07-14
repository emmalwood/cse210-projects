using System;

public class Program
{
    public static void Main(string[] args)
    {

                                            //street     town     state   country
        Address address1 = new Address("465 Sesame St", "Springfield", "NY", "USA");
        Address address2 = new Address("222 Maple Dr", "Toronto", "ON", "Canada");
        Address address3 = new Address("808 Peanuts St", "Normalville", "ID", "USA");

        
        Customer customer1 = new Customer("Oscar Grouch", address1);
        Customer customer2 = new Customer("Sue Sylvester", address2);
        Customer customer3 = new Customer("Charlie Brown", address3);

        
        Product product1 = new Product("Lamp", "L123", 999.99f, 1);
        Product product2 = new Product("Mirror", "M456", 19.99f, 2);
        Product product3 = new Product("Boots", "K789", 49.99f, 1);
        Product product4 = new Product("Iguana", "MO123", 199.99f, 1);
        Product product5 = new Product("Egg", "U456", 9.99f, 3);

        
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product4);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product5);

        Order order3 = new Order(customer3);
        order3.AddProduct(product5);
        order3.AddProduct(product4);
        order3.AddProduct(product2);

        
        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.TotalCost()}\n");

        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.TotalCost()}\n");

        Console.WriteLine(order3.PackingLabel());
        Console.WriteLine(order3.ShippingLabel());
        Console.WriteLine($"Total Cost: ${order3.TotalCost()}\n");
    }
}
