namespace ShoppingBasket.tests.utils;

public class MockProduct
{
    public static Product GetSomeProductWith(string productName)
    {
        return new Product(productName, 1.55f, 15, new Tax("normal", 21));
    }
}