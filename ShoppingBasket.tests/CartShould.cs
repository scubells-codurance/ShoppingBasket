using FluentAssertions;
using ShoppingBasket.tests.utils;

namespace ShoppingBasket.tests;

public class CartShould
{
    [Fact]
    public void AddOneProduct()
    {
        var cart = new Cart();
        var product = MockProduct.GetSomeProductWith("productName 📖");

        cart.AddProduct(product);
        var products = cart.Products;

        products.Should().BeEquivalentTo(new List<Product>() { product });
    }

    [Fact]
    public void getFormattedProductsWithEmptyProductList()
    {
        var expectedResult = """
--------------------------------------------
| Product name | Price with VAT | Quantity |
| -----------  | -------------- | -------- |
|------------------------------------------|
| Promotion:                               |
--------------------------------------------
| Total products: 0                        |
| Total price: 0.00 €                      |
--------------------------------------------
""";
        var cart = new Cart();

        var result = cart.getFormattedProducts();
        
        result.Should().Be(expectedResult);
    }
    
    [Fact]
    public void getFormattedProductsWithOneChicken()
    {
        var expectedResult =     """
 --------------------------------------------
 | Product name | Price with VAT | Quantity |
 | -----------  | -------------- | -------- |
 | Chicken 🍗   | 1.83 €         | 1        |
 |------------------------------------------|
 | Promotion:                               |
 --------------------------------------------
 | Total products: 1                        |
 | Total price: 1.83 €                      |
 --------------------------------------------
 """;
        var cart = new Cart();
        var chicken = MockProduct.GetSomeProductWith("Chicken 🍗");
        cart.AddProduct(chicken);

        var result = cart.getFormattedProducts();
        
        result.Should().Be(expectedResult);
    }
}