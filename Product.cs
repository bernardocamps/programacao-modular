class Product
{
    public string? description;
    public float? price;
    public int? quantity;

    public bool inStock()
    {
        return (quantity > 0);
    }
}