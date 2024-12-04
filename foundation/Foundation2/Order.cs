class Order
{
    private List<Product> Products;
    private Customer Customer;

    public Order(Customer customer)
    {
        Products = new List<Product>();
        Customer = customer;
    }

    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    public double TotalCost()
    {
        double total = 0;

        foreach (var product in Products)
        {
            total += product.TotalCost();
        }

        double shippingCost = Customer.LivesIn() ? 5 : 35;
        return total + shippingCost;
    }

    public string GetPackingLabel()
    {
        var packingLabel = "";

        foreach (var product in Products)
        {
            packingLabel += product.GetPackingInfo() + "\n";
        }

        return packingLabel.TrimEnd();
    }

    public string GetShippingLabel()
    {
        return $"{Customer.GetName()}\n{Customer.GetAddress()}";
    }
}
