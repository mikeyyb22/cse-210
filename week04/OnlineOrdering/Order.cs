public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    public float TotalOrderCost()
    {
        // Cost w/o Shipping Charge
        foreach (Product product in _products)
        {
            float productCost = product.TotalCost();
        }
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