using System;

class Program
{
    static void Main(string[] args)
    {   
        List<Product> products1 = new List<Product>();
        Address address1 = new Address("1400 N 300 W", "Austin", "Texas", "USA");
        Product product1 = new Product("Yarn", 1300, 5.32f, 2);
        Product product2 = new Product("shirt", 192, 25.92f, 1);
        products1.Add(product1);
        products1.Add(product2);
        Customer customer1 = new Customer("Jamie", address1);
        Order order1 = new Order(customer1, products1);
        
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("$" + order1.computeTotalPrice());

        List<Product> products2 = new List<Product>();
        Address address2 = new Address("3410 E 100 S", "Edmonton", "Alberta", "Canda");
        Product product3 = new Product("Needle", 1002, .99f, 10);
        Product product4 = new Product("Spool of Thread", 306, 2.17f, 1);
        products2.Add(product3);
        products2.Add(product4);
        Customer customer2 = new Customer("Landon", address2);
        Order order2 = new Order(customer2, products2);

        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("$" + order2.computeTotalPrice());

    }
}