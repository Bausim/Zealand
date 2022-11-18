using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

public class Order
{
   private double _totalPrice;
   private double _orderAmount;
   private double _deliveryPrice = 40;
   private Pizza _pizza;
   private Customer _customer;
   private double _tax = 0.25;
  
   
        
    public Order(Pizza pizza, Customer customer)
    { 
       
        _totalPrice = CalculateTotalPrice(pizza.Price);
        _pizza = pizza;
        _customer = customer;
        
    }

    public double TotalPrice
    {
        get { return _totalPrice; }
    }

    public string Pizza
        { 
        get { return Pizza; } 
        }

    public double DeliveryPrice
    {
        get { return _deliveryPrice; }
    }

    public double CalculateTotalPrice(double price)
    {
        return price + (price * _tax) + _deliveryPrice;

    }
    public override string ToString()
    {

        return $"{_pizza} {_customer}Full pris med levering efter moms: {_totalPrice}";
    }

}
