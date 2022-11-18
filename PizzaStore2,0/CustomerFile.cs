


using System.Runtime.InteropServices;

public class CustomerFile
{
    private static List<Customer> customerList = new List<Customer>();

  

    #region Methods

    // Add customer
    public static void AddCustomer(Customer customer)
    {
        customerList.Add(customer);
    }



    //Create CUSTOMER
    public static void AddCustomer(string name, string telefon, string address, string email)
    {
        customerList.Add(new Customer(name, telefon, address, email));
    }




    public static void RemoveCustomerByName(string name)
    {
        customerList.Remove(FindCustomerByName(name));
    }

  
    public static Customer FindCustomerByName(string name)
    {

       foreach (Customer item in customerList)
        {
            if (item.Name.ToLower() == name.ToLower())
            {

                return item;
            }
            
        }
        Console.WriteLine("No customer exists with that name");
        return null; 
    }




    //Tast bare ind nye verdiger
    public static void UpdateCustomer(string name, string newName, string newAddress, string newTelefon, string newEmail)
    {
        Customer customerToChange = FindCustomerByName(name);
        customerToChange.Name = newName;
        customerToChange.Address = newAddress;
        customerToChange.Email = newEmail;
        customerToChange.Telefon = newTelefon;
        
        }


    public static void PrintMenu()
    {
        foreach (Customer item in customerList)
        {
            Console.WriteLine(item);
        }


    }
    #endregion
}






