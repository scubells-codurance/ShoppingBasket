using FluentAssertions;

namespace ShoppingBasket.tests;

public class ProductRepositoryShould
{
    [Fact]
    public void GetProductByName()
    {
        var productRepository = new ProductRepository();
        var productName = "Chicken 🍗";

        var product = productRepository.GetProductBy(productName);

        var something = new Product(productName, 1.34f, 12, new Tax("normal", 21));
        product.Should().BeEquivalentTo(something);
    }
}