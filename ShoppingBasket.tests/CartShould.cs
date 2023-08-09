using FluentAssertions;

namespace ShoppingBasket.tests;

public class CartShould
{
    [Fact]
    public void AddOneProduct()
    {
        var cart = new Cart();
        var product = new Product("productName 📖", 1.55f, 15, new Tax("normal", 21));

        cart.AddProduct(product);
        var products = cart.Products;

        products.Should().BeEquivalentTo(new List<Product>() { product });
    }

    /*"""
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
 """*/
 
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
}