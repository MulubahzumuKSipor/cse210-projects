class Product
{
    private string Name;
    private string ProductId;
    private double Price;
    private int Quantity;

    public Product(string name, string productId, double price, int quantity)
    {
        Name = name;
        ProductId = productId;
        Price = price;
        Quantity = quantity;
    }

    public double TotalCost()
    {
        return Price * Quantity;
    }

    public string GetPackingInfo()
    {
        return $"{Name} (ID: {ProductId})";
    }
}
