public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order()
    {
        
    }

    public float TotalOrderCost()
    {
        return 0;
    }

    public string PackingLabel()
    {
        return "";
    }

    public string ShippingLabel()
    {
        return "";
    }

    public float TotalPrice()
    {
        return 0;
    }
}