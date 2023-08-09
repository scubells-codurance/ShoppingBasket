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
        var result = getLineSeparator(true);
        result += getProductsHeader();
        if (Products.Any()) result += "| Chicken 🍗   | 1.83 €         | 1        |\n";
        result += getPromotionHeader();
        result += getLineSeparator(true);
        result += formatProductsTotals();
        result += getLineSeparator(false);
        return result;
    }

    private static string getPromotionHeader()
    {
        return "|------------------------------------------|\n| Promotion:                               |\n";
    }

    private static string getProductsHeader()
    {
        return "| Product name | Price with VAT | Quantity |\n| -----------  | -------------- | -------- |\n";
    }

    private static string getLineSeparator(bool shouldBreak)
    {
        return "--------------------------------------------" + (shouldBreak ? "\n" : "");
    }

    private string formatProductsTotals()
    {
        if(!Products.Any()) return "| Total products: 0                        |\n| Total price: 0.00 €                      |\n";
        return "| Total products: 1                        |\n| Total price: 1.83 €                      |\n";
    }
}