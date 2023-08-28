namespace ShoppingBasket.tests.utils;

public class MockProduct
{
    public static Product GetSomeProductWith(string productName)
    {
        return new Product(productName, 1.55f, 15, new Tax("normal", 21));
    }

    public static Product GetChicken()
    {
        return new Product("Chicken 🍗", 1.34f, 12, new Tax("normal", 21));
    }
}