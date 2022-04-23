class Product
{
    public string? description;
    public float? price;
    public int? quantity;

    public Product(string description, float price, int quantity)
    {
        if (description.Length >= 3)
        {
            this.description = description;
        }
        if (price > 0)
        {
            this.price = price;
        }
        if (quantity >= 0)
        {
            this.quantity = quantity;
        }
    }
    public Product()
    {
        this.description = "New Product";
        this.price = 0.01F;
        this.quantity = 0;
    }

    public string inStock()
    {
        if (quantity > 0)
        {
            return "is available";
        }
        else
        {
            return "is not available";
        }
    }
}