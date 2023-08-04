namespace ShoppingBasket;

public interface ICart
{
    public List<Product> Products { get; }
    public void AddProduct(Product product);
    public string getFormattedProducts();
}

public class Cart : ICart
{
    public List<Product> Products { get; }

    public Cart()
    {
        Products = new List<Product>();
    }
    
    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    public string getFormattedProducts()
    {
        throw new NotImplementedException();
    }

}