using System;

class Program
{
    static void Main(string[] args)
    {
        Order order1 = CreateOrder1();
        Order order2 = CreateOrder2();
        Console.WriteLine(order1.DisplayOrder("Order 1"));
        Console.WriteLine(order2.DisplayOrder("Order 2"));
    }
    private static Order CreateOrder1()
    {
        Customer customer1 = new Customer(
            "Jane Walker",
            new Address("1231 Tamara Drive", "Pensacola", "FL", "USA")
        );
        var order = new Order(customer1);
        order.AddProduct(
            new Product("Nails", 1,.21, 100)            
        );
        order.AddProduct(
            new Product("4x4",2,4.5,10)
        );
        order.AddProduct(
            new Product("2x4",3,3,15)
        );
        return order;
    }

    private static Order CreateOrder2()
    {
        Customer customer1 = new Customer(
            "Joseph Farnsworth",
            new Address("123 Baker Street", "Westminster", "London", "United Kingdom")
        );
        var order = new Order(customer1);
        order.AddProduct(
            new Product("Screws", 4,.3, 75)            
        );
        order.AddProduct(
            new Product("4x6",5,4.75,20)
        );
        order.AddProduct(
            new Product("1x3",6,2.5,15)
        );
        return order;
    }
}