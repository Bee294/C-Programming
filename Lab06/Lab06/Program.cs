using Lab06;

List<Product> inv = new List<Product>();
//Add elements to the list
inv.Add(new Product("A", 5.9, 3));
inv.Add(new Product("B", 8.2, 2));
inv.Add(new Product("C", 3.5, 4));
inv.Add(new Product("D", 1.8, 8));

Console.WriteLine("Product list: ");
foreach(Product i in inv)
{
    Console.WriteLine("" + i);
}
