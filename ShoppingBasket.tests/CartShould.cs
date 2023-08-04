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
}