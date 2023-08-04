namespace ShoppingBasket;

public interface IShoppingBasket {
    public void AddItem(Product product);
    public void DeletItem(Product product);
    public void ApplyDiscount(Discount discount);
    public void PrintShoppingCart();
}

public class ShoppingBasket : IShoppingBasket
{
    public ShoppingBasket(IPrinter printer)
    {
        throw new NotImplementedException();
    }

    public void AddItem(Product product)
    {
        throw new NotImplementedException();
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


public class Product
{
    public Product(string name)
    {
        throw new NotImplementedException();
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