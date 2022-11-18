using System.Security.Cryptography.X509Certificates;

public class Store
{


    public Store()
    {

    }


    public static void Start()
    {
        CustomerFile.AddCustomer("Jens Lyn", "9964151", "Address1", "Email1");
        CustomerFile.AddCustomer("Lars lykke", "648999", "Address2", "Email2");
        CustomerFile.AddCustomer("Max Powers", "998678", "Address3", "Email3");
       




        PizzaMenu.CreatePizza("Hawaii", 75);
        PizzaMenu.CreatePizza("Gorganzilla", 95);
        PizzaMenu.CreatePizza("Cheese Monster", 125);

        Console.WriteLine("Find____Pizza");
        Console.WriteLine(PizzaMenu.FindPizza(0));

        Order order1 = new Order(PizzaMenu.FindPizza(0), CustomerFile.FindCustomerByName("Jens Lyn"));
        Order order2 = new Order(PizzaMenu.FindPizza(1), CustomerFile.FindCustomerByName("Lars Lykke"));
        Order order3 = new Order(PizzaMenu.FindPizza(2), CustomerFile.FindCustomerByName("Max Powers"));

        Console.WriteLine("_____Customer_List______");
        CustomerFile.PrintMenu();
        Console.WriteLine("______Update_Lars_Lykke________");
        CustomerFile.UpdateCustomer("Lars Lykke", "Mads Mikkelsen", "911", "Mosedammen 991", "MadsMikkelsenErCool@Gmail.com");
        CustomerFile.PrintMenu();
        Console.WriteLine("____Remove This Customer: "+CustomerFile.FindCustomerByName("Max Powers").Name);
        CustomerFile.RemoveCustomerByName("MAX POWeRS");
        CustomerFile.PrintMenu();

        Console.WriteLine("________PIZZA_MENU_________");
        PizzaMenu.PrintMenu();
        Console.WriteLine("____Update__Pizza____");
        PizzaMenu.UpdatePizza(1, "Cheese town", 98.5);
        PizzaMenu.PrintMenu();
        Console.WriteLine("__Remove_Pizza____");
        PizzaMenu.DeletePizza(1);
        PizzaMenu.PrintMenu();


        Console.WriteLine("");


        Console.WriteLine(order1);
        Console.WriteLine(order2);
        Console.WriteLine(order3);






    }

}
