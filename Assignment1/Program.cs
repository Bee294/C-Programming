

using Assignment1;

Controller controller = new Controller();
int choice;
Console.WriteLine("==========Menu==========");
Console.WriteLine("1.Add Product");
Console.WriteLine("2.Edit Product");
Console.WriteLine("3.Delete Product");
Console.WriteLine("4.View all Product");
Console.WriteLine("5.Search Product by ID");
Console.WriteLine("6.Seacrh Product by Name");
Console.WriteLine("7.End ");
choice = int.Parse(Console.ReadLine());
switch (choice)
{
    case 1:
        controller.CreateData();
        break;
    case 2:
        controller.EditData();
        break;
    case 3:
        controller.DeleteData();
        break;
    case 4:
        controller.ReadData();
        break;
    case 5:
        controller.SearchByID();
        break;
    case 6:
        controller.SearchByName();
        break;
    case 7:
        Console.WriteLine("Thank you for using our services!!!");
        break;
    default:
        break;
}
