namespace ShoppingBasket;

public interface ICart
{
    public void AddProduct(Product product);
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

}