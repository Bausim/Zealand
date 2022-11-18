public class Pizza
{
    private string _name;
    private double _price;
    private int _id = 0;
    private static int _idCounter = 0;

    public Pizza(string name, double price)
    {
        _id = _idCounter;
        _name = name;
        _price = price;
        _idCounter++;
    }



    public static int IdCounter
    { get { return _idCounter; } }
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
    public double Price
    { 
        get { return _price; }
        set { _price = value; }
    }

    public int Id
    {
        get { return _id; }
    }
    public override string ToString()
    {
        
        return $"Pizza Id: {_id} Pizza Name: {_name}. Price:  {_price} \n";
    }
}