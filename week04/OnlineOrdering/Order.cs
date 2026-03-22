public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    public double TotalOrderCost()
    {
        // Cost w/o Shipping Charge
        double totalCost = 0;
        foreach (Product product in _products)
        {
            double productCost = product.TotalCost();
            totalCost += productCost;
        }
        return totalCost;
    }

    public string PackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in _products)
        {
            string productName = product.GetName();
            int productId = product.GetId();
            packingLabel += $"{productName} - {productId}\n";
        }
        return packingLabel;
    }

    public string ShippingLabel()
    {
        string shippingLabel = "";
        string customerName = _customer.GetName();
        string customerAddress = _customer.GetAddress();
        shippingLabel += $"{customerName}\n{customerAddress}";

        return shippingLabel;
    }

    public double TotalPrice()
    {
        bool isInUS = _customer.LivesInUS();
        double shippingCost = 0;
        double totalPrice = 0;
        if (isInUS == true)
        {
            shippingCost = 5.0;
        }
        else
        {
            shippingCost = 35.0;
        }
        totalPrice = TotalOrderCost();
        totalPrice += shippingCost;

        return totalPrice;
    }
}