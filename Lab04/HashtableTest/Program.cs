using System.Collections;

Hashtable ht = new Hashtable();
ht.Add("a", "A");
ht.Add("b", "B");
ht.Add("c", "C");
ht.Add("e", "E");
ht["f"] = "F";
// Get a collection of the keys.
ICollection c = ht.Keys;
foreach (string str in c)
    Console.WriteLine(str + ": " + ht[str]);
