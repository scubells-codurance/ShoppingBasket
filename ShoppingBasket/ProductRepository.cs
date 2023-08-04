namespace ShoppingBasket;

public interface IProductRepository
{
    public Product GetProductBy(String name);
}

public class ProductRepository : IProductRepository
{
    private List<Product> products = new List<Product>()
    {
        new ("Chicken 🍗", 1.34f, 12, new Tax("normal", 21))
    };

    public Product GetProductBy(string name)
    {
        return products.Find(_ => _.name.Equals(name));
    }
}