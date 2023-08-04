namespace ShoppingBasket;

public interface IShoppingBasket {
    public void AddItem(string product);
    public void DeletItem(Product product);
    public void ApplyDiscount(Discount discount);
    public void PrintShoppingCart();
}

public class ShoppingBasket : IShoppingBasket
{
    private IPrinter printer;
    private IProductRepository productRepository;
    private ICart cart;

    public ShoppingBasket(IPrinter printer, IProductRepository productRepository, ICart cart)
    {
        this.cart = cart;
        this.productRepository = productRepository;
        this.printer = printer;
    }

    public void AddItem(string productName)
    {
        var product = productRepository.GetProductBy(productName);
        cart.AddProduct(product);
    }

    public void DeletItem(Product product)
    {
        throw new NotImplementedException();
    }

    public void ApplyDiscount(Discount discount)
    {
        throw new NotImplementedException();
    }

    public void PrintShoppingCart()
    {
        throw new NotImplementedException();
    }
}

public record Tax(string name, int value);

public class Product
{
    private string name;
    private float cost;
    private float revenue;
    private Tax tax;

    public Product(string name, float cost, float revenue, Tax tax)
    {
        this.tax = tax;
        this.revenue = revenue;
        this.cost = cost;
        this.name = name;
    }
}


public class Discount
{

}

public interface IPrinter
{

    public void Print(string message);
}

public class Printer : IPrinter
{
    public void Print(string message)
    {
        throw new NotImplementedException();
    }
}

public interface IProductRepository
{
    public Product GetProductBy(String name);
}

public class ProductRepository : IProductRepository
{
    public Product GetProductBy(string name)
    {
        throw new NotImplementedException();
    }
}

public interface ICart
{
    public void AddProduct(Product product);
}

public class Cart : ICart
{
    public void AddProduct(Product product)
    {
        throw new NotImplementedException();
    }
}