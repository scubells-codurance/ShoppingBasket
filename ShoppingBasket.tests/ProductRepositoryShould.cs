using FluentAssertions;
using ShoppingBasket.tests.utils;

namespace ShoppingBasket.tests;

public class ProductRepositoryShould
{
    [Fact]
    public void GetProductByName()
    {
        var productRepository = new ProductRepository();
        var productName = "Chicken 🍗";

        var product = productRepository.GetProductBy(productName);

        var something = MockProduct.GetSomeProductWith(productName);
        product.Should().BeEquivalentTo(something);
    }
}