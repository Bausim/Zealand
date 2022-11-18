

using System.Runtime.CompilerServices;

public class PizzaMenu
{
    private static Dictionary<int, Pizza> Menu = new Dictionary<int, Pizza>();

    public static void CreatePizza(string pizzaName, double pizzaPrice)
    {


        Menu.Add(Pizza.IdCounter, new Pizza(pizzaName, pizzaPrice));
    }
    public static void AddPizza(Pizza pizza)
    {
        Menu.Add(pizza.Id, pizza);
    }


    public static void UpdatePizza(int id, string newName, double newPrice)
    {
       Pizza pizzaToUpdate = FindPizza(id);
        pizzaToUpdate.Name = newName;
        pizzaToUpdate.Price = newPrice;

    }

    public static void DeletePizza(int id)
    {
       
            Menu.Remove(FindPizza(id).Id);
       
    }

    public static Pizza FindPizza(int id)
    {
        if (Menu.ContainsKey(id))
        {
            return Menu[id];
        }
        else
        {
            Console.WriteLine("Pizza not found");
            return null;

        }

    }

    public static void PrintMenu()
    {
        foreach (Pizza item in Menu.Values)
        {
            Console.Write(item);
        }

    }



}

