using System;

class Program
{
    static void Main(string[] args)
    {
        string prodName1 = "Bicycle";
        string prodName2 = "Extra chain";
        string prodName3 = "Basket";
        string prodName4 = "Bell";
        string prodName5 = "Extra tire";
        string prodName6 = "Reflective Light";

        int prodId1 = 10000;
        int prodId2 = 10001;
        int prodId3 = 10002;
        int prodId4 = 10003;
        int prodId5 = 10004;
        int prodId6 = 10005;

        int prodQuant1 = 1;
        int prodQuant2 = 3;
        int prodQuant3 = 1;
        int prodQuant4 = 1;
        int prodQuant5 = 4;
        int prodQuant6 = 2;

        double prodPrice1 = 599.99;
        double prodPrice2 = 29.99;
        double prodPrice3 = 5.99;
        double prodPrice4 = 2.99;
        double prodPrice5 = 39.99;
        double prodPrice6 = 2.99;

        Product product1 = new Product(prodName1, prodId1, prodPrice1, prodQuant1);
        Product product2 = new Product(prodName2, prodId2, prodPrice2, prodQuant2);
        Product product3 = new Product(prodName3, prodId3, prodPrice3, prodQuant3);
        Product product4 = new Product(prodName4, prodId4, prodPrice4, prodQuant4);
        Product product5 = new Product(prodName5, prodId5, prodPrice5, prodQuant5);
        Product product6 = new Product(prodName6, prodId6, prodPrice6, prodQuant6);

        List<Product> order = new List<Product> { product1, product2, product3, product4, product5, product6 };

        string customerName1 = "Bob Dobbs";
        string customerStreet1 = "244 Main St.";
        string customerCity1 = "Philadelphia";
        string customerState1 = "Pennsylvania";
        string customerCountry1 = "USA";

        string customerName2 = "Bub Dubbs";
        string customerStreet2 = "Rua 23 de Março, 66";
        string customerCity2 = "São Paulo";
        string customerState2 = "São Paulo";
        string customerCountry2 = "Brasil";

        Address address1 = new Address(customerStreet1, customerCity1, customerState1, customerCountry1);
        Address address2 = new Address(customerStreet2, customerCity2, customerState2, customerCountry2);

        Customer customer1 = new Customer(customerName1, address1);
        Customer customer2 = new Customer(customerName2, address2);

        Order order1 = new Order(order, customer1);
        Order order2 = new Order(order, customer2);

        string shippingLabel1 = order1.ShippingLabel();
        string packingLabel1 = order1.PackingLabel();
        double orderCost1 = order1.TotalPrice();

        string shippingLabel2 = order2.ShippingLabel();
        string packingLabel2 = order2.PackingLabel();
        double orderCost2 = order2.TotalPrice();

        Console.WriteLine($"{shippingLabel1}\n{packingLabel1}\n${orderCost1.ToString("F2")}");
        Console.WriteLine($"{shippingLabel2}\n{packingLabel2}\n${orderCost2.ToString("F2")}");

    }
}