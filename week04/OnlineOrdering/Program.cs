using System;
using System.Formats.Asn1;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        Console.WriteLine();

        
        Address a1 = new Address("105 Catnip Lane", "Montgomery", "AL", "USA");
        Customer c1 = new Customer("LittleMissMiso", a1);

        Order o1 = new Order(c1);

        Product p1 = new Product("Bananas", 4578, 1.99, 3);
        Product p2 = new Product("Bagels", 9246, 3.75, 2);
        Product p3 = new Product("Strawberries", 4289, 6.99, 1);

        o1.AddProducts(p1);
        o1.AddProducts(p2);
        o1.AddProducts(p3);

        c1.DisplayCustomerInfo();
        Console.WriteLine();

        Console.WriteLine(o1.ReturnPackingLabel());
        Console.WriteLine(o1.ReturnShippingLabel());
        Console.WriteLine($"TOTAL COST: ${o1.TotalOrderCost():F2}");

        Console.WriteLine();

        //ORDER #2
        Address a2 = new Address("Bag End", "Hobbiton", "SH", "The Shire");
        Customer c2 = new Customer("Bilbo Baggins", a2);

        Order o2 = new Order(c2);

        Product p4 = new Product("Longbottom Leaf", 9856, 16.99, 10);
        Product p5 = new Product("Potatoes", 1254, 0.50, 5);
        Product p6 = new Product("Lembas Bread", 8897, 13.75, 2);
        Product p7 = new Product("Wriggling Fish", 6675, 4.50, 2);

        o2.AddProducts(p4);
        o2.AddProducts(p5);
        o2.AddProducts(p6);
        o2.AddProducts(p7);

        c2.DisplayCustomerInfo();
        Console.WriteLine();

        Console.WriteLine(o2.ReturnPackingLabel());
        Console.WriteLine(o2.ReturnShippingLabel());
        Console.WriteLine($"TOTAL COST: ${o2.TotalOrderCost():F2}");

}
}