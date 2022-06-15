using Lab04;
using System.Collections;

ArrayList inv = new ArrayList();
//Add elements to the list

inv.Add(new Product("A", 5.9, 3));
inv.Add(new Product("B", 8.2, 2));
inv.Add(new Product("C", 3.5, 4));
inv.Add(new Product("D", 1.8, 8));

Console.WriteLine("Product List: ");
foreach (Product p in inv)
{
    Console.WriteLine("" + p);
}
