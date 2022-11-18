public class Customer
{
    private string _name;
    private int _id;
    private static int idCounter = 0;

    public Customer(string name, string telefon, string address, string email)
    {
        _id = idCounter;
        _name = name;
        idCounter++;
        Telefon = telefon;
        Address = address;
        Email = email;
        
    }

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public int Id
    { get { return _id; } }

    public string Telefon
    {
        get;
        set;
    }
    public string Address
    {
        get;
        set;
    }
    public string Email
    {
        get;
        set;
    }
   
    
    
    

    public override string ToString()
    {
        string customerInfo = $"Customer Id: {Id}\n" +
            $"Name: {_name}\n" +
             $"Phone Number: {Telefon}\n" +
             $"Address: {Address}\n" +
             $"Email: {Email}\n";
        return customerInfo;
    }
}